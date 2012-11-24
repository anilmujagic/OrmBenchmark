using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item099
    {
        public Item099()
        {
            this.OrderLine099 = new List<OrderLine099>();
        }

        public string Item099ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine099> OrderLine099 { get; set; }
    }
}
