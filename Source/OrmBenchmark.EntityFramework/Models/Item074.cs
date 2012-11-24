using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item074
    {
        public Item074()
        {
            this.OrderLine074 = new List<OrderLine074>();
        }

        public string Item074ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine074> OrderLine074 { get; set; }
    }
}
