using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item022
    {
        public Item022()
        {
            this.OrderLine022 = new List<OrderLine022>();
        }

        public string Item022ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine022> OrderLine022 { get; set; }
    }
}
