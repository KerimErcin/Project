using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider
{
    public partial class frmSlider : Form
    {
        public frmSlider()
        {
            InitializeComponent();
        }

        private void frmSlider_Load(object sender, EventArgs e)
        {
            lblLogin_Click(sender, e);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Slider(lblLogin.Name, lblLogin.Width, lblLogin.Left);
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Slider(lblSignUp.Name, lblSignUp.Width, lblSignUp.Left);
        }

        public void Slider(string lbl, int widht, int left)
        {
            if (lbl == "lblLogin")
            {
                pnlSelect.Left = left;
                pnlSelect.Width = widht;
                lblLogin.Font = new Font(lblLogin.Font, FontStyle.Bold);
                lblSignUp.Font = new Font(lblSignUp.Font, FontStyle.Regular);
            }
            else
            {
                pnlSelect.Left = left;
                pnlSelect.Width = widht;
                lblSignUp.Font = new Font(lblSignUp.Font, FontStyle.Bold);
                lblLogin.Font = new Font(lblLogin.Font, FontStyle.Regular);
            }
        }
    }
}
