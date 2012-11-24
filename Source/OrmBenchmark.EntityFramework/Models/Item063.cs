using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item063
    {
        public Item063()
        {
            this.OrderLine063 = new List<OrderLine063>();
        }

        public string Item063ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine063> OrderLine063 { get; set; }
    }
}
