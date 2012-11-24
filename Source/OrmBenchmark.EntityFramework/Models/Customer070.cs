using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer070
    {
        public Customer070()
        {
            this.Order070 = new List<Order070>();
        }

        public string Customer070ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order070> Order070 { get; set; }
    }
}
