using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.validators
{
    public class ValidatorLending : IValidator<Lending>
    {
        public void validate(Lending t)
        {
            string err = "";
            if (t.accountId <= 0)
                err += "Invalid account id!\n";
            if (t.bookCode <= 0)
                err += "Invalid bookcode!\n";
            if (err != "")
                throw new Exception(err);
        }
    }
}
