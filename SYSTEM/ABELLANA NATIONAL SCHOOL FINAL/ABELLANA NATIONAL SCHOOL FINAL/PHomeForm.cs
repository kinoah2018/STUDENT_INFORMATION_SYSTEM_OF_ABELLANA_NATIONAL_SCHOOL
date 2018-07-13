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
    public partial class PHomeForm : Form
    {
        public PHomeForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            LoginForm lf = new LoginForm();
            lf.ShowDialog();

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit ?", "Wait !", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }    
        }
    }
}
