using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item073
    {
        public Item073()
        {
            this.OrderLine073 = new List<OrderLine073>();
        }

        public string Item073ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine073> OrderLine073 { get; set; }
    }
}
