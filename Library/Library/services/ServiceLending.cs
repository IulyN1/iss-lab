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
    public class ServiceLending
    {
        private RepoLending repo;
        private ValidatorLending validator;

        public ServiceLending(RepoLending repoLending, ValidatorLending validLending)
        {
            this.repo = repoLending;
            this.validator = validLending;
        }

        public void addLending(int accountId, int bookCode, DateTime returnDate)
        {
            Lending lending = new Lending(accountId, bookCode, returnDate);
            validator.validate(lending);
            repo.addLending(lending);
        }

        public List<Lending> getLendings()
        {
            return repo.getLendings();
        }

        public Lending findOne(int bookCode, int accountId)
        {
            return repo.findById(bookCode, accountId);
        }

        public void updateLending(Lending lending)
        {
            repo.updateLending(lending);
        }

        public void deleteLending(int accountId, int bookCode)
        {
            Lending lending = repo.findById(bookCode, accountId);
            repo.deleteLending(lending);
        }
    }
}
