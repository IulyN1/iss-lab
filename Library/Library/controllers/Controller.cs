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
        private ServiceSubscriber serviceSubscriber;

        public Controller(ServiceAccount serviceAccount, ServiceSubscriber serviceSubscriber)
        {
            this.serviceAccount = serviceAccount;
            this.serviceSubscriber = serviceSubscriber;
        }

        public Account verifyAccount(string username, string password)
        {
           return serviceAccount.verifyAccount(username, password);
        }

        public void addSubscriber(string cnp, string firstName, string lastName, string phone, string address, string username, string password)
        {
            serviceAccount.addAccount(username, password);
            var accounts = serviceAccount.getAccounts();
            Account acc = accounts[accounts.Count - 1];
            serviceSubscriber.addSubscriber(cnp, firstName, lastName, phone, address, acc.id);
        }
    }
}
