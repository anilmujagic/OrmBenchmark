using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine089
    {
        public int OrderLine089ID { get; set; }
        public int Order089ID { get; set; }
        public string Item089ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item089 Item089 { get; set; }
        public virtual Order089 Order089 { get; set; }
    }
}
