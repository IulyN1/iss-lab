using Library.mapping;
using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.repository
{
    public class RepoLending
    {
        public void addLending(Lending lending)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.Save(lending);
                    transaction.Commit();
                }
            }
        }

        public void updateLending(Lending lending)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(lending);
                    transaction.Commit();
                }
            }
        }

        public void deleteLending(Lending lending)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(lending);
                    transaction.Commit();
                }
            }
        }

        public List<Lending> getLendings()
        {
            List<Lending> lendings = new List<Lending>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = from Lending in session.Query<model.Lending>()
                               select Lending;
                    foreach (var el in list)
                    {
                        lendings.Add(el);
                    }
                    transaction.Commit();
                }
            }
            return lendings;
        }

        public Lending findById(int bookCode, int accountId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = from Lending in session.Query<Lending>()
                               select Lending;
                    foreach (var el in list)
                    {
                        if (el.bookCode == bookCode && el.accountId == accountId)
                        {
                            transaction.Commit();
                            return el;
                        }
                    }
                }
            }
            return null;
        }
    }
}
