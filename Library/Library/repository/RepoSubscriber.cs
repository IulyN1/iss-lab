using Library.mapping;
using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.repository
{
    public class RepoSubscriber
    {
        public void addSubscriber(Subscriber subscriber)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    session.Save(subscriber);
                    transaction.Commit();
                }
            }
        }

        public void updateSubscriber(Subscriber subscriber)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(subscriber);
                    transaction.Commit();
                }
            }
        }

        public void deleteSubscriber(Subscriber subscriber)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(subscriber);
                    transaction.Commit();
                }
            }
        }

        public List<Subscriber> getSubscribers()
        {
            List<Subscriber> subscribers = new List<Subscriber>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = from Subscriber in session.Query<model.Subscriber>()
                               select Subscriber;
                    foreach (var el in list)
                    {
                        subscribers.Add(el);
                    }
                    transaction.Commit();
                }
            }
            return subscribers;
        }
    }
}
