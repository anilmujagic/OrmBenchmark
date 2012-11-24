using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item004
    {
        public Item004()
        {
            this.OrderLine004 = new List<OrderLine004>();
        }

        public string Item004ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine004> OrderLine004 { get; set; }
    }
}
