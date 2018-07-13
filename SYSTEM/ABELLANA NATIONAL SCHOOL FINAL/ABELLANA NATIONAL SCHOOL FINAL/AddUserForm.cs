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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            /*conn.Open();
            SqlCommand DropPosition = new SqlCommand("SELECT POSITION_TYPE FROM TBL_USERPOSITION", conn);
            SqlDataReader read = DropPosition.ExecuteReader();
            while (read.Read())
            {
                txtPosition.Items.Add(read[0]);
                txtPosition.Refresh();
            }

            conn.Close();
           */
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        DataClasses1DataContext db = new DataClasses1DataContext();
        Hashpass hp = new Hashpass();
        //public int CurrentID()
        //{
        //    return Convert.ToInt32(db.CURRENT_ID());
        //}

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewUserForm v = new ViewUserForm();
            v.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet.TBL_USERTYPE' table. You can move, or remove it, as needed.
            this.tBL_USERTYPETableAdapter.Fill(this.aNS_DATABASEDataSet.TBL_USERTYPE);
            //if (CurrentID() == 1)
            //{
            //    txtUser_ID.Text = "User-" + (CurrentID().ToString().PadLeft(5,'0'));
            //}
            //else
            //{
            //    txtUser_ID.Text = "User-" + (CurrentID() + 1).ToString().PadLeft(5, '0');
            //}
            txtPassword.Text = "1234";


        }
        public void ClearAll()
        {

            //if (CurrentID() == 1)
            //{
            //    txtUser_ID.Text = "User-" + (CurrentID().ToString().PadLeft(5, '0'));
            //}
            //else
            //{
            //    txtUser_ID.Text = "User-" + (CurrentID() + 1).ToString().PadLeft(5, '0');
            //}
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMiddlename.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtContactNo.Clear();
            PB_image.ImageLocation = null;
            cmbutype.SelectedItem = "";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Images | *.jpg";
            op.ShowDialog();
            Control_variables.img = op.FileName;
            PB_image.ImageLocation = Control_variables.img;
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtMiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm h = new HomeForm();
            AddUserForm a = new AddUserForm();
            h.msRegistration.BackColor = Color.Black;
            h.Refresh();
        }

        private void PB_image_Click(object sender, EventArgs e)
        {

        }

        private void cmbutype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_USERNAME LIKE'" + txtUsername.Text + "'", conn);
            string get_uname = Convert.ToString(command.ExecuteScalar());
            conn.Close();
            if (txtLastname.Text == "" || txtFirstname.Text == "" || txtMiddlename.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtContactNo.Text == "" || PB_image.ImageLocation == null)
            {
                MessageBox.Show("Information Required! Please fill out the necessary fields", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (txtUsername.Text == get_uname)
            {
                MessageBox.Show("Username exist already", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Control_variables.type = "Administrator";
                TBL_USER u = new TBL_USER();
                string dateNow = DateTime.Now.ToShortDateString();
                u.USER_IMAGE = Control_variables.img;
                Image im = Image.FromFile(Control_variables.img);
                u.USER_IMAGE = Photo.byteArrayToBase64String(Photo.imageToByteArray(im));
                db.SP_USERSAVE(txtLastname.Text,txtFirstname.Text ,txtMiddlename.Text,txtUsername.Text,txtPassword.Text ,txtContactNo.Text,Control_variables.type,int.Parse(cmbutype.SelectedValue.ToString()),Control_variables.img);
                MessageBox.Show("Successfully Saved!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClearAll();
            }
        }
    }
        
}
    
        