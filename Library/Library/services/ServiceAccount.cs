using Library.model;
using Library.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.services
{
    public class ServiceAccount
    {
        private RepoAccount repoAccount;

        public ServiceAccount(RepoAccount repoAccount)
        {
            this.repoAccount = repoAccount;
        }

        public void addAccount(String username, String password)
        {
            Account account = new Account(username, password);
            repoAccount.addAccount(account);
        }

        public List<Account> getAccounts()
        {
            return repoAccount.getAccounts();
        }

        public Account verifyAccount(String username, String password)
        {
            foreach (Account account in getAccounts())
            {
                if (account.username == username && account.password == password)
                {
                    return account;
                }
            }
            throw new Exception("Invalid username and password!");
        }
    }
}
