using Library.model;
using Library.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.controllers
{
    public class Controller
    {
        private ServiceAccount serviceAccount;
        private ServiceSubscriber serviceSubscriber;
        private ServiceBook serviceBook;
        private ServiceLending serviceLending;

        public Controller(ServiceAccount serviceAccount, ServiceSubscriber serviceSubscriber, 
            ServiceBook serviceBook, ServiceLending serviceLending)
        {
            this.serviceAccount = serviceAccount;
            this.serviceSubscriber = serviceSubscriber;
            this.serviceBook = serviceBook;
            this.serviceLending = serviceLending;
        }

        public Account verifyAccount(string username, string password)
        {
           return serviceAccount.verifyAccount(username, password);
        }

        public void addSubscriber(string cnp, string firstName, string lastName, string phone, string address, string username, string password)
        {
            serviceAccount.addAccount(username, password);
            var accounts = serviceAccount.getAccounts();
            Account acc = accounts[accounts.Count - 1];
            serviceSubscriber.addSubscriber(cnp, firstName, lastName, phone, address, acc.id);
        }

        public void addBook(string title, string author, int year, int noOfCopies)
        {
            serviceBook.addBook(title, author, year, noOfCopies);
        }

        public void updateBook(int isbn, string title, string author, int year, int noOfCopies)
        {
            serviceBook.updateBook(isbn, title, author, year, noOfCopies);
        }

        public void deleteBook(int isbn)
        {
            serviceBook.deleteBook(isbn);
        }

        public List<Book> getBooks()
        {
            return serviceBook.getBooks();
        }

        public void addLending(int accountId, int bookCode, DateTime returnDate)
        {
            serviceLending.addLending(accountId, bookCode, returnDate);
            Book book = serviceBook.findBookById(bookCode);
            serviceBook.updateBook(bookCode, book.title, book.author, book.year, book.noOfCopies - 1);
        }

        public List<Book> getAvailableBooks(int accountId)
        {
            return serviceBook.getAvailableBooks(accountId);
        }

        public List<Book> getBorrowedBooks(int accountId)
        {
            return serviceBook.getBorrowedBooks(accountId);
        }

        public void changeLendingStatus(int bookCode, int accountId, string status)
        {
            Lending lending = serviceLending.findOne(bookCode, accountId);
            lending.status = status;
            serviceLending.updateLending(lending);
        }

        public List<Lending> getLendings()
        {
            return serviceLending.getLendings();
        }

        public void returnBook(int accountId, int bookCode)
        {
            serviceLending.deleteLending(accountId, bookCode);
            Book book = serviceBook.findBookById(bookCode);
            serviceBook.updateBook(bookCode, book.title, book.author, book.year, book.noOfCopies + 1);
        }
    }
}
