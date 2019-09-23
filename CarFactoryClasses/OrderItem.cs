using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryClasses
{
    public class OrderItem
    {
        public OrderItem()
        {
            Id = Guid.NewGuid();
            Items = new List<Item>();

            
        }

        public virtual Guid Id { get; set; }

        public virtual int Qty { get; set; }

        public virtual decimal Price { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        

        
         






    }
}
