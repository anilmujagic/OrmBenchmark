using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine046
    {
        public int OrderLine046ID { get; set; }
        public int Order046ID { get; set; }
        public string Item046ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item046 Item046 { get; set; }
        public virtual Order046 Order046 { get; set; }
    }
}
