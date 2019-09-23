using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryClasses;
using FluentNHibernate.Automapping.Alterations;

namespace MappingClasses
{
    public class OrderItemMap:IAutoMappingOverride<OrderItem>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<OrderItem> mapping)
        {
            //mapping.Table("OrderDetails");
            mapping.Id(o => o.Id).Not.GeneratedBy.Assigned();
            mapping.Map(o => o.Qty);
            mapping.Map(o => o.Price);
            mapping.HasMany(o => o.Items).Cascade.AllDeleteOrphan();
            
            
        }
    }
}
