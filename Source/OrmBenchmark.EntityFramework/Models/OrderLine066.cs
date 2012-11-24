using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine066
    {
        public int OrderLine066ID { get; set; }
        public int Order066ID { get; set; }
        public string Item066ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item066 Item066 { get; set; }
        public virtual Order066 Order066 { get; set; }
    }
}
