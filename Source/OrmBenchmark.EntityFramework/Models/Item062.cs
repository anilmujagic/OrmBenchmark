using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item062
    {
        public Item062()
        {
            this.OrderLine062 = new List<OrderLine062>();
        }

        public string Item062ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine062> OrderLine062 { get; set; }
    }
}
