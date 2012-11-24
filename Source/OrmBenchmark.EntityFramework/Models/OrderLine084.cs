using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine084
    {
        public int OrderLine084ID { get; set; }
        public int Order084ID { get; set; }
        public string Item084ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item084 Item084 { get; set; }
        public virtual Order084 Order084 { get; set; }
    }
}
