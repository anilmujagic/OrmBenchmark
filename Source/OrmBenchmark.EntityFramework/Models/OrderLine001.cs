using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine001
    {
        public int OrderLine001ID { get; set; }
        public int Order001ID { get; set; }
        public string Item001ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item001 Item001 { get; set; }
        public virtual Order001 Order001 { get; set; }
    }
}
