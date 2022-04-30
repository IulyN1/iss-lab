using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Library.repository;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.mapping
{
    public class NHibernateHelper
    {

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory(); 
                return _sessionFactory;
            }
        }

        public static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
			
            .Database(PostgreSQLConfiguration.Standard
            .ConnectionString(c => c
            .Host("localhost")
            .Port(5432)
            .Database("library")
            .Username("postgres")
            .Password("postgres")))

         .Mappings(m => m.FluentMappings
         .AddFromAssemblyOf<RepoAccount>())
         .ExposeConfiguration(cfg => new SchemaExport(cfg))
         .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
