using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void btnChange_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //var scan = db.VERIFYPASSWORD(UserID.Text, txtDefaultpass.Text);


            //foreach (VERIFYPASSWORDResult user in scan)
            //{
            //    if (txtNewpass.Text == "" || txtRetypepass.Text == "")
            //    {
            //        MessageBox.Show("Please Input New Password");
            //    }
            //    else
            //    {
            //        count++;


            //        if (txtNewpass.Text == txtRetypepass.Text)
            //        {
            //            user.USER_PASSWORD = txtNewpass.Text;
            //            db.CHANGEPASSWORD(lbusername.Text, user.USER_PASSWORD);
            //            TBL_USER user2 = new TBL_USER();
            //            MessageBox.Show("Password Updated Successfully");

            //            //CLEAR TEXTBOXES
            //            txtDefaultpass.Clear();
            //            txtNewpass.Clear();
            //            txtRetypepass.Clear();

            //            MessageBox.Show("Welcome " + Control_variables.username);
            //            LoginForm log = new LoginForm();
            //            log.txtUsername.Clear();
            //            log.txtPassword.Clear();

            //            HomeForm h = new HomeForm();

                        
            //            // GET PICTURE 
            //            conn.Open();
            //            SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USER WHERE USER_ID = '" + txtID.Text+ "'", conn);
            //            Control_variables.img = Convert.ToString(command.ExecuteScalar());
            //            h.pictureBox2.ImageLocation = Control_variables.img;
            //            conn.Close();
            //            h.lbUsername.Text = Control_variables.username;
            //            h.lbPosition.Text = Control_variables.namePosition;
                        
                        
            //            h.ShowDialog();
                        
            //            this.Close();
                        
            //        }
            //        else
            //        {
            //            MessageBox.Show("Password did not match");
            //        }

            //    }


            //}
            //if (count == 0)
            //{
            //    MessageBox.Show("Account does not Exist");
            //}
  
            if (txtNewpass.Text != "" && txtRetypepass.Text != "")
            {
                if (txtNewpass.Text != "1234" && txtRetypepass.Text != "1234")
                {
                    if (txtNewpass.Text.Length >= 8)
                    {
                        if (txtNewpass.Text == txtRetypepass.Text)
                        {
                            //textBox1.Text = "UPDATE TBL_USER SET USER_PASSWORD = '" + txtNewpass.Text + "' WHERE USER_ID LIKE'" + txtID.Text + "'";
                            conn.Open();
                            SqlCommand updatePass = new SqlCommand("UPDATE TBL_USERS SET USER_PASSWORD = '" + txtNewpass.Text + "' WHERE USER_ID ='" + UserID.Text + "'", conn);
                            updatePass.ExecuteNonQuery();
                            conn.Close();
                            DialogResult dialog = MessageBox.Show("Password successfully changed ! \nDo you want to continue logging in ?", "Congrats !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialog == DialogResult.Yes)
                            {
                                conn.Open();
                                SqlCommand username = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);
                                SqlCommand password = new SqlCommand("SELECT USER_PASSWORD FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);
                                SqlCommand userStat = new SqlCommand("SELECT ISACTIVE FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);
                                SqlCommand FName = new SqlCommand("SELECT USER_FIRSTNAME FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);
                                SqlCommand LName = new SqlCommand("SELECT USER_LASTNAME FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);
                                SqlCommand position = new SqlCommand("SELECT USER_POSITION FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);
                                SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_ID LIKE '" + UserID.Text + "'", conn);

                                //CREATE STRING VARIABLES

                                string usern = Convert.ToString(username.ExecuteScalar());
                                string pass = Convert.ToString(password.ExecuteScalar());
                                string stat = Convert.ToString(userStat.ExecuteScalar());
                                string FIname = Convert.ToString(FName.ExecuteScalar());
                                string LAname = Convert.ToString(LName.ExecuteScalar());
                                string post = Convert.ToString(position.ExecuteScalar());

                                conn.Close();
                                HomeForm h = new HomeForm();

                                // GET PICTURE 
                                conn.Open();
                                SqlCommand get_pic = new SqlCommand("SELECT USER_IMAGE FROM TBL_USER WHERE USER_ID='" + UserID.Text + "'", conn);
                                Control_variables.img = Convert.ToString(get_pic.ExecuteScalar());
                                h.pictureBox2.ImageLocation = Control_variables.img;

                                h.lbUsername.Text = Control_variables.username;
                                h.lbPosition.Text = Control_variables.type;
                                this.Close();
                                h.ShowDialog();
                                conn.Close();
                            }
                            else
                            {
                                this.Close();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewpass.Focus();
                            txtRetypepass.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewpass.Clear();
                        txtRetypepass.Clear();
                        txtNewpass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please do not use the default password.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewpass.Clear();
                    txtRetypepass.Clear();
                    txtNewpass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields","Ooops !",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are changing your default pass! \nDo you want to close this form?","Oops.",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialog)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
