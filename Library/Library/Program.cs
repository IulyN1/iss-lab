using Library.controllers;
using Library.mapping;
using Library.repository;
using Library.services;
using Library.validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            RepoAccount repoAccount = new RepoAccount();
            RepoSubscriber repoSubscriber = new RepoSubscriber();
            RepoBook repoBook = new RepoBook();
            RepoLending repoLending = new RepoLending();

            ValidatorAccount validatorAccount = new ValidatorAccount();
            ValidatorSubscriber validatorSubscriber = new ValidatorSubscriber();
            ValidatorBook validatorBook = new ValidatorBook();
            ValidatorLending validatorLending = new ValidatorLending();

            ServiceAccount serviceAccount = new ServiceAccount(repoAccount, validatorAccount);
            ServiceSubscriber serviceSubscriber = new ServiceSubscriber(repoSubscriber, validatorSubscriber);
            ServiceBook serviceBook = new ServiceBook(repoBook, validatorBook);
            ServiceLending serviceLending = new ServiceLending(repoLending, validatorLending);

            Controller controller = new Controller(serviceAccount,serviceSubscriber,serviceBook,serviceLending);
            MainLibrary mainLibrary = new MainLibrary(controller);

            Application.Run(mainLibrary);
        }
    }
}
