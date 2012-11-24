using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine051
    {
        public int OrderLine051ID { get; set; }
        public int Order051ID { get; set; }
        public string Item051ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item051 Item051 { get; set; }
        public virtual Order051 Order051 { get; set; }
    }
}
