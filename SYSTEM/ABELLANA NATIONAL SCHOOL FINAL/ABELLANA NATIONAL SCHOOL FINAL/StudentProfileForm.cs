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
    public partial class StudentProfileForm : Form
    {
        
        public StudentProfileForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewStudentProfileForm spv = new ViewStudentProfileForm();
            spv.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtlname.Text == "" || cmbylevel.Text == "" || cmbsyear.Text == "" || dtpbdate.Text == "" || txtage.Text == "" || cmbgen.Text == "" || txtcnumber.Text == "" || cmbstatus.Text == "" || txtheight.Text == "" || txtweight.Text == "" || txtbp.Text == "" || txtpid.Text == "" || txtsid.Text== "" )
            {
                MessageBox.Show("Input All Fields!","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else 
            {
                //db.ST_SAVE(txtfname.Text, txtmname.Text, txtlname.Text, cmbylevel.Text, cmbsyear.Text, DateTime.Parse(dtpbdate.Text), int.Parse(txtage.Text), txtbp.Text, txtadd.Text, cmbgen.Text, txtcnumber.Text, cmbstatus.Text, int.Parse(txtheight.Text), int.Parse(txtweight.Text), int.Parse(txtbp.Text), int.Parse(txtpid.Text), int.Parse(txtsid.Text));
                //MessageBox.Show("Successfully Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void dtpbdate_ValueChanged(object sender, EventArgs e)
        {
            txtage.Text = (DateTime.Today.Year - dtpbdate.Value.Year).ToString();
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtheight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtoccu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtptype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        

        

      
        
       

       
       
    }
}
