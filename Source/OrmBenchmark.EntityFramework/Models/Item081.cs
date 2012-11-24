using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item081
    {
        public Item081()
        {
            this.OrderLine081 = new List<OrderLine081>();
        }

        public string Item081ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine081> OrderLine081 { get; set; }
    }
}
