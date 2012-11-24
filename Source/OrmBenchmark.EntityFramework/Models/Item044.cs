using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item044
    {
        public Item044()
        {
            this.OrderLine044 = new List<OrderLine044>();
        }

        public string Item044ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine044> OrderLine044 { get; set; }
    }
}
