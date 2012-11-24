using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item090
    {
        public Item090()
        {
            this.OrderLine090 = new List<OrderLine090>();
        }

        public string Item090ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine090> OrderLine090 { get; set; }
    }
}
