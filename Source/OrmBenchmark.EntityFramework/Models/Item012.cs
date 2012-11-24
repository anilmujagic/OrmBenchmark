using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item012
    {
        public Item012()
        {
            this.OrderLine012 = new List<OrderLine012>();
        }

        public string Item012ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine012> OrderLine012 { get; set; }
    }
}
