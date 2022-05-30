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
    public partial class Terminal : Form
    {
        private Controller controller;
        private Account account;
        public Terminal(Controller controller, Account account)
        {
            InitializeComponent();
            this.controller = controller;
            this.account = account;

            comboBoxTerminal.Items.Clear();
            comboBoxTerminal.Items.Add("Borrow books");
            comboBoxTerminal.Items.Add("Return books");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(comboBoxTerminal.SelectedItem.ToString() == "Borrow books")
            {
                var frm = new Dashboard(controller, account);
                frm.Show();
                this.Hide();
            }
            else if (comboBoxTerminal.SelectedItem.ToString() == "Return books")
            {
                var frm = new Returnal(controller, account);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a terminal!", "Error!");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var frm = new MainLibrary(controller);
            frm.Show();
            this.Hide();
        }
    }
}
