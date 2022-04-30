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
    public partial class Returnal : Form
    {
        private Controller controller;
        public Returnal(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var frm = new MainLibrary(controller);
            frm.Show();
            this.Hide();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var frm = new Terminal(controller);
            frm.Show();
            this.Hide();
        }
    }
}
