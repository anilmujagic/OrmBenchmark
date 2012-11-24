using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine045
    {
        public int OrderLine045ID { get; set; }
        public int Order045ID { get; set; }
        public string Item045ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item045 Item045 { get; set; }
        public virtual Order045 Order045 { get; set; }
    }
}