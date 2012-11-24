using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine037
    {
        public int OrderLine037ID { get; set; }
        public int Order037ID { get; set; }
        public string Item037ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item037 Item037 { get; set; }
        public virtual Order037 Order037 { get; set; }
    }
}
