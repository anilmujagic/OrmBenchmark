using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item083
    {
        public Item083()
        {
            this.OrderLine083 = new List<OrderLine083>();
        }

        public string Item083ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine083> OrderLine083 { get; set; }
    }
}
