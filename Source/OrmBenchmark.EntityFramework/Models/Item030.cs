using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item030
    {
        public Item030()
        {
            this.OrderLine030 = new List<OrderLine030>();
        }

        public string Item030ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine030> OrderLine030 { get; set; }
    }
}
