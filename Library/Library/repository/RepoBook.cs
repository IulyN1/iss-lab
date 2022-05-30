using Library.mapping;
using Library.model;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.repository
{
    public class RepoBook
    {
        public void addBook(Book book)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.Save(book);
                    transaction.Commit();
                }
            }
        }

        public void updateBook(Book book)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(book);
                    transaction.Commit();
                }
            }
        }

        public void deleteBook(Book book)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(book);
                    transaction.Commit();
                }
            }
        }

        public List<Book> getBooks()
        {
            List<Book> books = new List<Book>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = from Book in session.Query<model.Book>()
                                   select Book;
                    foreach (var el in list)
                    {
                        books.Add(el);
                    }
                    transaction.Commit();
                }
            }
            return books;
        }

        public Book findById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = from Book in session.Query<Book>()
                               select Book;
                    foreach (var el in list)
                    {
                        if (el.bookCode == id)
                        {
                            transaction.Commit();
                            return el;
                        }
                    }
                }
            }
            return null;
        }

        public List<Book> getAvailableBooks(int accountId)
        {
            List<Book> books = new List<Book>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    QueryOver<Lending> subQuery = QueryOver.Of<Lending>().Where(x => x.accountId == accountId).Select(y => y.bookCode);
                    var list = session.QueryOver<Book>().WithSubquery.WhereProperty(c => c.bookCode).NotIn(subQuery).List();
                    foreach (var el in list)
                    {
                        books.Add(el);
                    }
                    transaction.Commit();
                }
            }
            return books;
        }

        public List<Book> getBorrowedBooks(int accountId)
        {
            List<Book> books = new List<Book>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    QueryOver<Lending> subQuery = QueryOver.Of<Lending>().Where(x => x.accountId == accountId && x.status == "borrowed").Select(y => y.bookCode);
                    var list = session.QueryOver<Book>().WithSubquery.WhereProperty(c => c.bookCode).In(subQuery).List();
                    foreach (var el in list)
                    {
                        books.Add(el);
                    }
                    transaction.Commit();
                }
            }
            return books;
        }
    }
}
