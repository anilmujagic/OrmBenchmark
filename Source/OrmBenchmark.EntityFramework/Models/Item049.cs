using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item049
    {
        public Item049()
        {
            this.OrderLine049 = new List<OrderLine049>();
        }

        public string Item049ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine049> OrderLine049 { get; set; }
    }
}
