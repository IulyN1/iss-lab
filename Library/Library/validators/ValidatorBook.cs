using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.validators
{
    public class ValidatorBook : IValidator<Book>
    {
        public void validate(Book t)
        {
            string err = "";
            if (t.title == "")
                err += "Empty title!\n";
            if (t.author == "")
                err += "Empty author!\n";
            if (t.year <= 0)
                err += "Invalid year!\n";
            if (t.noOfCopies <= 0)
                err += "Invalid number of copies!\n";
            if (err != "")
                throw new Exception(err);
        }
    }
}
