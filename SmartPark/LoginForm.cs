using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPark
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txUserName.Text == "a" && this.txPassword.Text == "1")
            {
                MainForm main = new MainForm();
                this.Visible = false;
                main.ShowDialog();
            }else
            {
                this.txInfo.Text = "密码错误";
                this.txInfo.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txUserName.Text = "";
            this.txPassword.Text = "";
            this.txInfo.Visible = false;
        }

        private void txUserName_TextChanged(object sender, EventArgs e)
        {
            this.txInfo.Visible = false;
        }

        private void txPassword_TextChanged(object sender, EventArgs e)
        {
            this.txInfo.Visible = false;
        }
    }
}
