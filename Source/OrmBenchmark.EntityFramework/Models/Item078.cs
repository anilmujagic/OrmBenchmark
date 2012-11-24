using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item078
    {
        public Item078()
        {
            this.OrderLine078 = new List<OrderLine078>();
        }

        public string Item078ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine078> OrderLine078 { get; set; }
    }
}
