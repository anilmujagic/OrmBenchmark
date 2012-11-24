using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine006
    {
        public int OrderLine006ID { get; set; }
        public int Order006ID { get; set; }
        public string Item006ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item006 Item006 { get; set; }
        public virtual Order006 Order006 { get; set; }
    }
}
