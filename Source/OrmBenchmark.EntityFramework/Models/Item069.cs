using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item069
    {
        public Item069()
        {
            this.OrderLine069 = new List<OrderLine069>();
        }

        public string Item069ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine069> OrderLine069 { get; set; }
    }
}
