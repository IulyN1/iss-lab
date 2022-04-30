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

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var frm = new MainLibrary(controller);
            frm.Show();
            this.Hide();
        }
    }
}
