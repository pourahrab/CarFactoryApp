using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryClasses;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace MappingClasses
{
    public class OrderMap :IAutoMappingOverride<Order>
    {
        public void Override(AutoMapping<Order> mapping)
        {
            //mapping.Table("Order");
            mapping.Id(o => o.Id).Not.GeneratedBy.Assigned();
            mapping.Map(o => o.Date).Generated.Always();
            mapping.HasOne(o => o.customer).Cascade.All();
            mapping.HasMany(o => o.OrderItems).Cascade.AllDeleteOrphan();
        }
    }
}
