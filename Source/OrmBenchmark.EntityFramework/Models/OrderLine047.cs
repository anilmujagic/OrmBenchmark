using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine047
    {
        public int OrderLine047ID { get; set; }
        public int Order047ID { get; set; }
        public string Item047ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item047 Item047 { get; set; }
        public virtual Order047 Order047 { get; set; }
    }
}
