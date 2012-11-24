using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item038
    {
        public Item038()
        {
            this.OrderLine038 = new List<OrderLine038>();
        }

        public string Item038ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine038> OrderLine038 { get; set; }
    }
}
