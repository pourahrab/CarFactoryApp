using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryClasses;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace MappingClasses
{
   public class NHibernateClass
   {
       private static ISessionFactory _SessionFactory;

       public static ISessionFactory SessionFactory
       {
           get
           {
               if (_SessionFactory == null)
               {
                   InitializeSessionFactory();
               }

               return _SessionFactory;
           }
           
       }

       private static void InitializeSessionFactory()
       {
           var cfgi = new ConfigurationClass();
           _SessionFactory = Fluently.Configure().Database
               (MsSqlConfiguration.MsSql2012
                   .ConnectionString(
                       @"Data Source=.;Initial Catalog=CarFactoryApp;Persist Security Info=True;User ID=sa;Password=sa123")

                   .ShowSql()).Mappings(m => m.AutoMappings

                   .Add(AutoMap.AssemblyOf<Customer>(cfgi)

                       .UseOverridesFromAssemblyOf<CustomerMap>()))

               .ExposeConfiguration(conf =>
               {
                   new SchemaUpdate(conf).Execute(false, false);

                   new SchemaExport(conf).Create(true, true);
               })

               .BuildSessionFactory();
       }

       public static ISession OpenSession()
       {
           return SessionFactory.OpenSession();
       }
   }
}
