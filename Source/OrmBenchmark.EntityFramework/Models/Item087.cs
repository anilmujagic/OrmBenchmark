using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item087
    {
        public Item087()
        {
            this.OrderLine087 = new List<OrderLine087>();
        }

        public string Item087ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine087> OrderLine087 { get; set; }
    }
}
