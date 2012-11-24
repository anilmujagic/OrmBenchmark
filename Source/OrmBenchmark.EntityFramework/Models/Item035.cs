using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item035
    {
        public Item035()
        {
            this.OrderLine035 = new List<OrderLine035>();
        }

        public string Item035ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine035> OrderLine035 { get; set; }
    }
}
