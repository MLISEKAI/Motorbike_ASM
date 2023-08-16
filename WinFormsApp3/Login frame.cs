using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;

namespace Motorcycle_management
{
    public partial class Login_frame : Form
    {
        public Login_frame()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Check the username and password entered.
            if (txt_acc.Text == "admin" && txt_pass.Text == "1234")
            {
                // If true, show successful login message.
                MessageBox.Show("Successful login", "Notify",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create and display the management form (Management_framework).
                Management_framework Open = new Management_framework();
                Open.Show();
                // Hide the login form so the user can't come back after logging in.
                this.Hide();
            }
            else
            {
                // If false, display a message asking to re-enter.
                MessageBox.Show("You have not logged in with your account and password. " +
                    "Please re-enter", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ckb_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is selected, show password.
            if (ckb_showpass.Checked)
            {
                // '\0' is the password to display as plain text.
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                // '*' is the password displayed as an asterisk.
                txt_pass.PasswordChar = '*';
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            // Exit the application completely.
            Application.Exit();
        }

    }
}
