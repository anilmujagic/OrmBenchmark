using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item051
    {
        public Item051()
        {
            this.OrderLine051 = new List<OrderLine051>();
        }

        public string Item051ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine051> OrderLine051 { get; set; }
    }
}
