using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine092
    {
        public int OrderLine092ID { get; set; }
        public int Order092ID { get; set; }
        public string Item092ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item092 Item092 { get; set; }
        public virtual Order092 Order092 { get; set; }
    }
}
