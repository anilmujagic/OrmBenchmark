using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine074
    {
        public int OrderLine074ID { get; set; }
        public int Order074ID { get; set; }
        public string Item074ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item074 Item074 { get; set; }
        public virtual Order074 Order074 { get; set; }
    }
}
