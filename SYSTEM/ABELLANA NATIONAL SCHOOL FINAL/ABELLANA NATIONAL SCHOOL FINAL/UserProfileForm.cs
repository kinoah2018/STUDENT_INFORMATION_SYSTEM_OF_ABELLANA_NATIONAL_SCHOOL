using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void btnUpdatepass_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            int count = 0;

            if (txtOldpass.Text == "" || txtNewpass.Text == "" || txtRetypepass.Text == "")
            {
                MessageBox.Show("Please input data","Ooops !",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {

                var scan = db.SP_VERIFYPASSWORD(txtUserID.Text, txtOldpass.Text);
                db.SubmitChanges();

                foreach (SP_VERIFYPASSWORDResult user in scan)
                {
                    count++;
                  if(txtNewpass.Text.Length >=8)
                    {
                        if(txtNewpass.Text == txtRetypepass.Text)
                            {
                                user.USER_PASSWORD = txtNewpass.Text;
                                db.SP_CHANGEPASSWORD(Control_variables.current_id, user.USER_PASSWORD);
                                TBL_USER user2 = new TBL_USER();
                                MessageBox.Show("Password Successfully Changed","Success !",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                //CLEAR TEXTBOXES
                                txtOldpass.Clear();
                                txtNewpass.Clear();
                                txtRetypepass.Clear();
                                groupChangePass.Visible = false;
                            }
                        else
                            {
                                MessageBox.Show("Password did not match", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                    }
                    else
                    {
                        MessageBox.Show("Password must be contain atleast 8 characters long ","Ooops !",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }

                }
                if (count == 0)
                {
                    MessageBox.Show("Old password Incorrect","Ooops !",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            groupChangePass.Visible = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtOldpass.Clear();
            txtNewpass.Clear();
            txtRetypepass.Clear();
            groupChangePass.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
