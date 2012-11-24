using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine042
    {
        public int OrderLine042ID { get; set; }
        public int Order042ID { get; set; }
        public string Item042ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item042 Item042 { get; set; }
        public virtual Order042 Order042 { get; set; }
    }
}
