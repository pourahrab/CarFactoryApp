using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryClasses
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;

            OrderItems = new List<OrderItem>();
        }

        public virtual Guid Id { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual Customer customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } 


    }
}
