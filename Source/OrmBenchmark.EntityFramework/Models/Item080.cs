using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item080
    {
        public Item080()
        {
            this.OrderLine080 = new List<OrderLine080>();
        }

        public string Item080ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine080> OrderLine080 { get; set; }
    }
}
