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
using System.IO;
using System.Drawing.Imaging;

namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    public partial class ViewUserForm : Form
    {
        public ViewUserForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dgViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            //this.tbL_USERTableAdapter1.Fill(this.ANS_DATABASE_V2Dataset1.TBL_USER);
            dgViewUser.DataSource=db.View_Users;
        }
      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("No data to be Search","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                dgViewUser.DataSource = db.SP_USERSEARCH(txtSearch.Text);
            }
        }

        private void dgViewUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateUserForm uuf = new UpdateUserForm();


            uuf.txtUser_ID.Text = dgViewUser.CurrentRow.Cells[0].Value.ToString();
            uuf.txtLastname.Text = dgViewUser.CurrentRow.Cells[1].Value.ToString();
            uuf.txtFirstname.Text = dgViewUser.CurrentRow.Cells[2].Value.ToString();
            uuf.txtMiddlename.Text = dgViewUser.CurrentRow.Cells[3].Value.ToString();
            uuf.txtUsername.Text = dgViewUser.CurrentRow.Cells[4].Value.ToString();
            uuf.txtContactNo.Text = dgViewUser.CurrentRow.Cells[5].Value.ToString();
            if (dgViewUser.CurrentRow.Cells[7].Value.ToString() == "True")
            {
                uuf.cmbStatus.SelectedIndex = 0;
            }
            else
            {
                uuf.cmbStatus.SelectedIndex = 1;
            }
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_ID='"+dgViewUser.CurrentRow.Cells[0].Value.ToString()+"'",conn);
            string get_pic = Convert.ToString(cmd.ExecuteScalar());
            uuf.PB_image.ImageLocation = get_pic;
            conn.Close();
            uuf.ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgViewUser.DataSource = db.View_Users;
            }
        }
    }
}
