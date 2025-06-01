using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using LibrarySystem.Includes;

namespace LibrarySystem
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;

        private void OK_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tbluser` WHERE User_name= '" + UsernameTextBox.Text + "' and Pass = sha1('" + PasswordTextBox.Text + "')";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                Form frm = new Form1();
                this.Hide();

                frm.Show();
            }
            else
            {
                MessageBox.Show("Account does not exist. Please contact administrator.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
