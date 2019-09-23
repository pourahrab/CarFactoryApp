using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryClasses
{
    public class Item
    {
        public Item()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual decimal Price { get; set; }

     
    }
}
