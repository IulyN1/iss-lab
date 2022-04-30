using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.validators
{
    public class ValidatorSubscriber : IValidator<Subscriber>
    {
        public void validate(Subscriber t)
        {
            string err = "";
            if (t.cnp == "")
                err += "Empty cnp!\n";
            if (t.firstName == "")
                err += "Empty first name!\n";
            if (t.lastName == "")
                err += "Empty last name!\n";
            if (t.phone == "")
                err += "Empty phone!\n";
            if (t.address == "")
                err += "Empty address!\n";
            if (err != "")
                throw new Exception(err);
        }
    }
}
