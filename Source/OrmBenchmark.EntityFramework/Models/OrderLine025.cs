using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine025
    {
        public int OrderLine025ID { get; set; }
        public int Order025ID { get; set; }
        public string Item025ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item025 Item025 { get; set; }
        public virtual Order025 Order025 { get; set; }
    }
}
