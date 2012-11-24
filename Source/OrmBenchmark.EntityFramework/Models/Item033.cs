using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item033
    {
        public Item033()
        {
            this.OrderLine033 = new List<OrderLine033>();
        }

        public string Item033ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine033> OrderLine033 { get; set; }
    }
}
