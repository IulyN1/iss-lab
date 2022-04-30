using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.validators
{
    public class ValidatorAccount : IValidator<Account>
    {
        public void validate(Account t)
        {
            string err = "";
            if (t.username == "")
                err += "Empty username!\n";
            if (t.password == "")
                err += "Empty password!\n";
            if (err != "")
                throw new Exception(err);
        }
    }
}
