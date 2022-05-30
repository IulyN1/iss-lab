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
    public partial class Manager : Form
    {
        private Controller controller;
        private DataTable booksData;
        private DataTable returnsData;
        private string state;

        public Manager(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

            returnsData = new DataTable();
            returnsData.Columns.Add("ISBN");
            returnsData.Columns.Add("AccountId"); 
            returnsData.Columns.Add("BorrowDate");
            returnsData.Columns.Add("ReturnDate");

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

        private void label1_Click(object sender, EventArgs e){}

        public void showBooks()
        {
            state = "All books";
            var books = controller.getBooks();
            booksData.Clear();

            foreach (var book in books)
            {
                booksData.Rows.Add(new object[] { book.bookCode, book.title, book.author, book.year, book.noOfCopies });
            }
            dataGridViewBooks.DataSource = booksData;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var titleValue = textBoxTitle.Text;
                var authorValue = textBoxAuthor.Text;
                var yearValue = int.Parse(textBoxYear.Text);
                var copiesValue = int.Parse(textBoxNoOfCopies.Text);
                controller.addBook(titleValue, authorValue, yearValue, copiesValue);
                showBooks();
                MessageBox.Show("Book successfully added!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewBooks.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Select a book first!");
                    return;
                }
                var isbnValue = int.Parse(dataGridViewBooks.SelectedRows[0].Cells[0].Value.ToString());
                var titleValue = textBoxTitle.Text;
                var authorValue = textBoxAuthor.Text;
                var yearValue = int.Parse(textBoxYear.Text);
                var copiesValue = int.Parse(textBoxNoOfCopies.Text);
                controller.updateBook(isbnValue, titleValue, authorValue, yearValue, copiesValue);
                showBooks();
                MessageBox.Show("Book successfully updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBooks.SelectedRows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Select a book first!");
                    return;
                }
                var isbnValue = int.Parse(dataGridViewBooks.SelectedRows[0].Cells[0].Value.ToString());
                controller.deleteBook(isbnValue);
                showBooks();
                MessageBox.Show("Book successfully deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            showBooks();
        }

        public void showPendingReturnal()
        {
            state = "Returning books";
            var returnals = controller.getLendings();
            returnsData.Clear();

            foreach (var el in returnals)
            {
                if(el.status == "returning")
                    returnsData.Rows.Add(new object[] { el.bookCode, el.accountId, el.borrowDate, el.returnDate });
            }
            dataGridViewBooks.DataSource = returnsData;
        }

        private void buttonPendingReturns_Click(object sender, EventArgs e)
        {
            showPendingReturnal();
        }

        private void buttonConfirmReturn_Click(object sender, EventArgs e)
        {
            if(state == "Returning books")
            {
                var accountId = dataGridViewBooks.SelectedRows[0].Cells[0].Value;
                var bookCode = dataGridViewBooks.SelectedRows[0].Cells[1].Value;
                if (bookCode == null || accountId == null)
                {
                    MessageBox.Show("Select a record first!");
                    return;
                }
                controller.returnBook(int.Parse(accountId.ToString()), int.Parse(bookCode.ToString()));
                showPendingReturnal();
                MessageBox.Show("Return confirmed!");
            }
        }
    }
}
