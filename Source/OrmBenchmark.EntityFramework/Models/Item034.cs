using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item034
    {
        public Item034()
        {
            this.OrderLine034 = new List<OrderLine034>();
        }

        public string Item034ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine034> OrderLine034 { get; set; }
    }
}
