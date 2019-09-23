using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryClasses;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Conventions.Helpers;


namespace MappingClasses
{
    public class CustomerMap : IAutoMappingOverride<Customer>
    {
        public void Override(AutoMapping<Customer> mapping)
        {
            //mapping.Table("CustomerInfo");
            mapping.Id(c => c.Id).Not.GeneratedBy.Assigned();
            mapping.Map(c => c.FName);
            mapping.Map(c => c.LName);
            mapping.Map(c => c.Phone);
           
        }
    }
}
