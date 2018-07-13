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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //ADO CONNECTION
            conn.Open();

            SqlCommand username = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand ID = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand password = new SqlCommand("SELECT USER_PASSWORD FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand isActive = new SqlCommand("SELECT ISACTIVE FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand FName = new SqlCommand("SELECT USER_FIRSTNAME FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand LName = new SqlCommand("SELECT USER_LASTNAME FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand type = new SqlCommand("SELECT USER_TYPEID FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);

            //CREATE STRING VARIABLES

            string usern = Convert.ToString(username.ExecuteScalar());
            string USERID = Convert.ToString(ID.ExecuteScalar());
            string pass = Convert.ToString(password.ExecuteScalar());
            string stat = Convert.ToString(isActive.ExecuteScalar());
            string FIname = Convert.ToString(FName.ExecuteScalar());
            string LAname = Convert.ToString(LName.ExecuteScalar());
            int utype = Convert.ToInt32(type.ExecuteScalar());
            if (utype == 1)
            {
                Control_variables.type = "Admin";
            }
            else if (utype == 2)
            {
                Control_variables.type = "Registrar";
            }
            else
            {
                Control_variables.type = "Staff";
            }
            conn.Close();


            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    Control_variables.username = "Admin";
                    Control_variables.type = "Admin";
                    MessageBox.Show("Welcome Administrator");
                    HomeForm h = new HomeForm();
                    txtUsername.Clear();
                    txtPassword.Clear();

                    h.lbUsername.Text = Control_variables.username;
                    h.lbPosition.Text = Control_variables.type;
                    h.groupBox1.Visible = false;
                    h.btnProfile.Visible = false;
                    h.ShowDialog();

                    this.Close();

                }
                else if (txtUsername.Text == usern && txtPassword.Text == pass)
                {
                    ChangePassForm changepass = new ChangePassForm();
                    Control_variables.username = FIname.ToString() + " " + LAname.ToString();
                    if (utype == 1)
                    {
                        Control_variables.type = "Admin";
                    }
                    else if (utype == 2)
                    {
                        Control_variables.type = "Registrar";
                    }
                    else
                    {
                        Control_variables.type = "Staff";
                    }
                    
                       if (stat == "True")
                       {
                           if (pass == "1234")
                           {
                               conn.Open();
                               SqlCommand get_id = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME='"+txtUsername.Text+"'",conn);
                               Control_variables.current_id = Convert.ToInt32(get_id.ExecuteScalar());
                               changepass.lbusername.Text = Control_variables.username;
                               changepass.UserID.Text =Control_variables.current_id.ToString();
                               changepass.txtDefaultpass.Text = pass.ToString();

                               txtUsername.Clear();
                               txtPassword.Clear();
                               changepass.ShowDialog();
                               conn.Close();
                           }
                           else
                           {
                               
                               MessageBox.Show("Welcome " + Control_variables.username,"",MessageBoxButtons.OK,MessageBoxIcon.Information);

                               HomeForm h = new HomeForm();
                               //MessageBox.Show(Control_variables.namePosition);                      
                               // GET PICTURE 
                               conn.Open();
                               SqlCommand get_pic = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_USERNAME LIKE'"+txtUsername.Text+"'",conn);
                               Control_variables.img = Convert.ToString(get_pic.ExecuteScalar());
                               h.pictureBox2.ImageLocation = Control_variables.img;
                               SqlCommand get_id = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME LIKE'"+txtUsername.Text+"'",conn);
                               Control_variables.current_id = Convert.ToInt32(get_id.ExecuteScalar());

                               conn.Close();

                               //PASS VARIABLES
                               h.lbUsername.Text = Control_variables.username;
                               h.lbPosition.Text = Control_variables.type;
                                                                                       
                               //CLEAR TEXTBOXES
                               txtUsername.Clear();
                               txtPassword.Clear();

                              
                               
                               h.ShowDialog();
                          }
                       }
                      else
                       {
                           MessageBox.Show("Your account is Inactive, contact your Administrator.","Ooops !",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                           txtPassword.Clear();
                           txtUsername.Focus();
                       }
                }
                else
                {
                    MessageBox.Show("Incorrect Username and Password!");
                    txtPassword.Clear();
                    txtUsername.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please input Username and Password");
                txtUsername.Focus();
            }

            }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        }
    }

