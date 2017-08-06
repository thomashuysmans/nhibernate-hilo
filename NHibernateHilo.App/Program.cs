using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHilo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionFactory = CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {

                for (var i = 0; i < 10; i++)
                {
                    var person = new Person()
                    {
                        Name = "SomeName",
                        Surname = "SomeSurname",
                        Age = 20
                    };
                    
                    session.Save(person);
                }
                transaction.Commit();
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var dbSetup = MsSqlConfiguration.MsSql2012.ConnectionString(ConfigurationManager.ConnectionStrings["NHibernateHiloConnectionString"].ConnectionString).AdoNetBatchSize(80);

            return Fluently.Configure()
              .Database(dbSetup)
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
        }
    }
}
