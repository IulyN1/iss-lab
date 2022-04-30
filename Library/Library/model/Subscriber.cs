using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.model
{
    [Serializable]
    public class Subscriber
    {
        public virtual string cnp { get; set; }
        public virtual string firstName { get; set; }
        public virtual string lastName { get; set; }
        public virtual string phone { get; set; }
        public virtual string address { get; set; }
        public virtual int accountId { get; set; }

        public Subscriber(string cnp, string firstName, string lastName, string phone, string address, int accountId)
        {
            this.cnp = cnp;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.address = address;
            this.accountId = accountId;
        }
        public Subscriber() { }
    }
}
