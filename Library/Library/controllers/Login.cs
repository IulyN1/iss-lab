using Library.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.controllers
{
    public partial class Login : Form
    {
        private Controller controller;

        public Login(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            try
            {
                Account account = controller.verifyAccount(username, password);
                if (account.admin)
                {
                    var frm = new Manager(controller);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    var frm = new Terminal(controller, account);
                    frm.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var frm = new MainLibrary(controller);
            frm.Show();
            this.Hide();
        }
    }
}
