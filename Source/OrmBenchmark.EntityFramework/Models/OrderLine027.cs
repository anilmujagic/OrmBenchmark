using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine027
    {
        public int OrderLine027ID { get; set; }
        public int Order027ID { get; set; }
        public string Item027ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item027 Item027 { get; set; }
        public virtual Order027 Order027 { get; set; }
    }
}
