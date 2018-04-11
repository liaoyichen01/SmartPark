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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();*/
        }

        private void MenuItemQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
