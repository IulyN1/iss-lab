using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.model
{
    public class Lending
    {
        public virtual int id { get; set; }
        public virtual int accountId { get; set; }
        public virtual int bookCode { get; set; }
        public virtual DateTime borrowDate { get; set; }
        public virtual DateTime returnDate { get; set; }
        public virtual string status { get; set; }

        public Lending() { }

        public Lending(int id, int accountId, int bookCode, DateTime borrowDate, DateTime returnDate, string status)
        {
            this.id = id;
            this.accountId = accountId;
            this.bookCode = bookCode;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.status = status;
        }

        public Lending(int accountId, int bookCode, DateTime borrowDate, DateTime returnDate, string status)
        {
            this.id = 0;
            this.accountId = accountId;
            this.bookCode = bookCode;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.status = status;
        }

        public Lending(int accountId, int bookCode, DateTime returnDate)
        {
            this.id = 0;
            this.accountId = accountId;
            this.bookCode = bookCode;
            this.borrowDate = DateTime.Now;
            this.returnDate = returnDate;
            this.status = "borrowed";
        }
    }
}
