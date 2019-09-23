using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryClasses;
using FluentNHibernate.Automapping.Alterations;

namespace MappingClasses
{
    public class ItemMap:IAutoMappingOverride<Item>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<Item> mapping)
        {
            //mapping.Table("Items");
            mapping.Id(i => i.Id).Not.GeneratedBy.Assigned();
            mapping.Map(i => i.Name);
            mapping.Map(i => i.Price);
        }
    }
}
