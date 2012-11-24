using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item009
    {
        public Item009()
        {
            this.OrderLine009 = new List<OrderLine009>();
        }

        public string Item009ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine009> OrderLine009 { get; set; }
    }
}
