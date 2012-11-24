using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine100
    {
        public int OrderLine100ID { get; set; }
        public int Order100ID { get; set; }
        public string Item100ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item100 Item100 { get; set; }
        public virtual Order100 Order100 { get; set; }
    }
}
