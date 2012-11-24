using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item015
    {
        public Item015()
        {
            this.OrderLine015 = new List<OrderLine015>();
        }

        public string Item015ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine015> OrderLine015 { get; set; }
    }
}
