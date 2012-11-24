using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item018
    {
        public Item018()
        {
            this.OrderLine018 = new List<OrderLine018>();
        }

        public string Item018ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine018> OrderLine018 { get; set; }
    }
}
