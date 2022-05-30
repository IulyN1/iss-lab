using Library.model;
using Library.repository;
using Library.validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.services
{
    public class ServiceBook
    {
        private ValidatorBook validator;
        private RepoBook repo;

        public ServiceBook(RepoBook repo, ValidatorBook validator)
        {
            this.repo = repo;
            this.validator = validator;
        }

        public void addBook(string title, string author, int year, int noOfCopies)
        {
            Book book = new Book(title, author, year, noOfCopies);
            validator.validate(book);
            repo.addBook(book);
        }

        public void updateBook(int isbn, string title, string author, int year, int noOfCopies)
        {
            Book book = new Book(isbn, title, author, year, noOfCopies);
            validator.validate(book);
            repo.updateBook(book);
        }

        public void deleteBook(int isbn)
        {
            Book book = repo.findById(isbn);
            repo.deleteBook(book);
        }

        public Book findBookById(int isbn)
        {
            Book book = repo.findById(isbn);
            return book;
        }

        public List<Book> getBooks()
        {
            return repo.getBooks();
        }

        public List<Book> getAvailableBooks(int accountId)
        {
            return repo.getAvailableBooks(accountId);
        }

        public List<Book> getBorrowedBooks(int accountId)
        {
            return repo.getBorrowedBooks(accountId);
        }
    }
}
