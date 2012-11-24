using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item059
    {
        public Item059()
        {
            this.OrderLine059 = new List<OrderLine059>();
        }

        public string Item059ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine059> OrderLine059 { get; set; }
    }
}
