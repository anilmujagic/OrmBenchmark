using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item075
    {
        public Item075()
        {
            this.OrderLine075 = new List<OrderLine075>();
        }

        public string Item075ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine075> OrderLine075 { get; set; }
    }
}
