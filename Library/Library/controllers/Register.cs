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
    public partial class Register : Form
    {
        private Controller controller;

        public Register(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string cnp = textBoxCNP.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            try
            {
                controller.addSubscriber(cnp, firstName, lastName, phone, address, username, password);
                var frm = new MainLibrary(controller);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
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
