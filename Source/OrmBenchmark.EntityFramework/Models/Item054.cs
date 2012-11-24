using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item054
    {
        public Item054()
        {
            this.OrderLine054 = new List<OrderLine054>();
        }

        public string Item054ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine054> OrderLine054 { get; set; }
    }
}
