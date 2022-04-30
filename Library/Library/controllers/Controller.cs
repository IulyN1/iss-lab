using Library.model;
using Library.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.controllers
{
    public class Controller
    {
        private ServiceAccount serviceAccount;

        public Controller(ServiceAccount serviceAccount)
        {
            this.serviceAccount = serviceAccount;
        }

        public Account verifyAccount(string username, string password)
        {
           return serviceAccount.verifyAccount(username, password);
        }
    }
}
