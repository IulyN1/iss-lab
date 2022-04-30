using Library.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainLibrary : Form
    {
        private Controller controller;

        public MainLibrary(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var frm = new Login(controller);
            frm.Location = this.Location;
            frm.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var frm = new Register(controller);
            frm.Show();
            this.Hide();
        }
    }
}
