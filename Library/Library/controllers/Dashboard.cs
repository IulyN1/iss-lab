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
    public partial class Dashboard : Form
    {
        private Controller controller;
        private Account account;
        private DataTable booksData;
        public Dashboard(Controller controller, Account account)
        {
            InitializeComponent();
            this.controller = controller;
            this.account = account;
            labelHello.Text = "Hello, " + account.username + "!";

            booksData = new DataTable();
            booksData.Columns.Add("ISBN");
            booksData.Columns.Add("Title");
            booksData.Columns.Add("Author");
            booksData.Columns.Add("Year");
            booksData.Columns.Add("NoOfCopies");

            dataGridViewBooks.DataSource = booksData;
            showBooks();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var frm = new MainLibrary(controller);
            frm.Show();
            this.Hide();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var frm = new Terminal(controller, account);
            frm.Show();
            this.Hide();
        }

        public void showBooks()
        {
            labelBooks.Text = "Available books";
            var books = controller.getAvailableBooks(account.id);
            booksData.Clear();

            foreach (var book in books)
            {
                if (book.noOfCopies > 0)
                    booksData.Rows.Add(new object[] { book.bookCode, book.title, book.author, book.year, book.noOfCopies });
            }
            dataGridViewBooks.DataSource = booksData;
        }

        public void showBorrowed()
        {
            labelBooks.Text = "Borrowed books";
            var books = controller.getBorrowedBooks(account.id);
            booksData.Clear();

            foreach (var book in books)
            {
                booksData.Rows.Add(new object[] { book.bookCode, book.title, book.author, book.year, book.noOfCopies });
            }
            dataGridViewBooks.DataSource = booksData;
        }

        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            showBooks();
        }

        private void buttonViewBorrowed_Click(object sender, EventArgs e)
        {
            showBorrowed();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            var bookCode = dataGridViewBooks.SelectedRows[0].Cells[0].Value;
            var returnDate = dateTimePickerReturnal.Value;
            if (bookCode == null)
            {
                MessageBox.Show("Select a book first!");
                return;
            }
            else if (returnDate <= DateTime.UtcNow)
            {
                MessageBox.Show("Please select a valid returnal date!");
                return;
            }
            controller.addLending(account.id, int.Parse(bookCode.ToString()), returnDate);
            showBooks();
            MessageBox.Show("Book successfully borrowed!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
