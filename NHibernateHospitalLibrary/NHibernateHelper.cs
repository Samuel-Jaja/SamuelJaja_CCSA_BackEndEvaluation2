using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernateHospitalLibrary.Mapping;
using NHibernateHospitalLibrary.Models;

namespace NHibernateHospitalLibrary
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    InitializeSessionFatory();
                }
                return sessionFactory;
            }
        }

        public static void InitializeSessionFatory()
        {
                sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samuel Jaja\Documents\databasetest.mdf;Integrated Security=True;Connect Timeout=30")
                .ShowSql()
                )
                .Mappings(m => m.FluentMappings
                .AddFromAssemblyOf<Hospital>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}