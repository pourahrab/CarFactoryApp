using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryClasses
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual string FName { get; set; }

        public virtual string LName { get; set; }

        public virtual string Phone { get; set; }
    }
}
