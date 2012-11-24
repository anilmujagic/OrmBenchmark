using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item047
    {
        public Item047()
        {
            this.OrderLine047 = new List<OrderLine047>();
        }

        public string Item047ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine047> OrderLine047 { get; set; }
    }
}
