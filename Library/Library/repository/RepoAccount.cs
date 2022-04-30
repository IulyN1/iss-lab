using Library.mapping;
using Library.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.repository
{
    public class RepoAccount
    {
        public void addAccount(Account account)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.Save(account);
                    transaction.Commit();
                }
            }
        }

        public void updateAccount(Account account)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(account);
                    transaction.Commit();
                }
            }
        }

        public void deleteAccount(Account account)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(account);
                    transaction.Commit();
                }
            }
        }

        public List<Account> getAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = from Account in session.Query<model.Account>()
                                   select Account;
                    foreach (var el in list)
                    {
                        accounts.Add(el);
                    }
                    transaction.Commit();
                }
            }
            return accounts;
        }
    }
}
