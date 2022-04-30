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

            RepoAccount repoAccount = new RepoAccount();
            RepoSubscriber repoSubscriber = new RepoSubscriber();

            ValidatorAccount validatorAccount = new ValidatorAccount();
            ValidatorSubscriber validatorSubscriber = new ValidatorSubscriber();

            ServiceAccount serviceAccount = new ServiceAccount(repoAccount, validatorAccount);
            ServiceSubscriber serviceSubscriber = new ServiceSubscriber(repoSubscriber, validatorSubscriber);

            Controller controller = new Controller(serviceAccount,serviceSubscriber);
            MainLibrary mainLibrary = new MainLibrary(controller);

            Application.Run(mainLibrary);
        }
    }
}
