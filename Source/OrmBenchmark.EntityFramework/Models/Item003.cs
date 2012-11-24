using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item003
    {
        public Item003()
        {
            this.OrderLine003 = new List<OrderLine003>();
        }

        public string Item003ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine003> OrderLine003 { get; set; }
    }
}
