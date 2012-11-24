using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine026
    {
        public int OrderLine026ID { get; set; }
        public int Order026ID { get; set; }
        public string Item026ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item026 Item026 { get; set; }
        public virtual Order026 Order026 { get; set; }
    }
}
