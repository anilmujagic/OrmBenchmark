using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item042
    {
        public Item042()
        {
            this.OrderLine042 = new List<OrderLine042>();
        }

        public string Item042ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine042> OrderLine042 { get; set; }
    }
}
