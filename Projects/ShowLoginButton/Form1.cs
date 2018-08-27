using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowLoginButton
{
    public partial class frmShowButton : Form
    {
        public frmShowButton()
        {
            InitializeComponent();
        }

        private void frmShowButton_Load(object sender, EventArgs e)
        {
            btnLogin.Visible = false;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            Control(txtUser.Name, txtPassword.Text, txtUser.Text);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Control(txtPassword.Name, txtUser.Name, txtPassword.Text);
        }

        public void Control(string name, string text, string empty)
        {
            if (name == "txtUser")
            {
                if (empty == string.Empty || txtPassword.Text == string.Empty)
                {
                    btnLogin.Visible = false;
                }
                else
                {
                    btnLogin.Visible = true;
                }
            }
            else /*if (name == "txtPassword")*/
            {
                if (empty == string.Empty || txtUser.Text == string.Empty)
                {
                    btnLogin.Visible = false;
                }
                else
                {
                    btnLogin.Visible = true;
                }
            }
        }
    }
}
