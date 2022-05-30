using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.model
{
    public class Book
    {
        public virtual int bookCode { get; set; }
        public virtual string title { get; set; }
        public virtual string author { get; set; }
        public virtual int year { get; set; }
        public virtual int noOfCopies { get; set; }

        public Book() { }

        public Book(int book_code, string title, string author, int year, int noOfCopies)
        {
            this.bookCode = book_code;
            this.title = title;
            this.author = author;
            this.year = year;
            this.noOfCopies = noOfCopies;
        }

        public Book(string title, string author, int year, int noOfCopies)
        {
            this.bookCode = 0;
            this.title = title;
            this.author = author;
            this.year = year;
            this.noOfCopies = noOfCopies;
        }
    }
}
