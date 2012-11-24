using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine063
    {
        public int OrderLine063ID { get; set; }
        public int Order063ID { get; set; }
        public string Item063ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item063 Item063 { get; set; }
        public virtual Order063 Order063 { get; set; }
    }
}
