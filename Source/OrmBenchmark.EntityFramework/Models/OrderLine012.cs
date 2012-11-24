using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine012
    {
        public int OrderLine012ID { get; set; }
        public int Order012ID { get; set; }
        public string Item012ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item012 Item012 { get; set; }
        public virtual Order012 Order012 { get; set; }
    }
}
