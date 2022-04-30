using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.model
{
    [Serializable]
    public class Account
    {
        public virtual int id { get; set; }
        public virtual string username { get; set; }
        public virtual string password { get; set; }
        public virtual bool admin { get; set; }


        public Account(string username, string password)
        {
            this.id = 0;
            this.username = username;
            this.password = password;
            this.admin = false;
        }

        public Account()
        {
        }

    }
}
