using Library.model;
using Library.repository;
using Library.validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.services
{
    public class ServiceSubscriber
    {
        private RepoSubscriber repoSubscriber;
        private ValidatorSubscriber validatorSubscriber;

        public ServiceSubscriber(RepoSubscriber repoSubscriber, ValidatorSubscriber validatorSubscriber)
        {
            this.repoSubscriber = repoSubscriber;
            this.validatorSubscriber = validatorSubscriber;
        }

        public void addSubscriber(string cnp, string firstName, string lastName, string phone, string address, int accountId)
        {
            Subscriber subscriber = new Subscriber(cnp, firstName, lastName, phone, address, accountId);
            validatorSubscriber.validate(subscriber);
            repoSubscriber.addSubscriber(subscriber);
        }

        public List<Subscriber> getSubscribers()
        {
            return repoSubscriber.getSubscribers();
        }
    }
}
