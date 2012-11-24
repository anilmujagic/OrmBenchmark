using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item008
    {
        public Item008()
        {
            this.OrderLine008 = new List<OrderLine008>();
        }

        public string Item008ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine008> OrderLine008 { get; set; }
    }
}
