using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine054
    {
        public int OrderLine054ID { get; set; }
        public int Order054ID { get; set; }
        public string Item054ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item054 Item054 { get; set; }
        public virtual Order054 Order054 { get; set; }
    }
}
