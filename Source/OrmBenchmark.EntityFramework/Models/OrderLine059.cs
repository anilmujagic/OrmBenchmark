using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine059
    {
        public int OrderLine059ID { get; set; }
        public int Order059ID { get; set; }
        public string Item059ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item059 Item059 { get; set; }
        public virtual Order059 Order059 { get; set; }
    }
}
