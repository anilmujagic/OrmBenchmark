using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine060
    {
        public int OrderLine060ID { get; set; }
        public int Order060ID { get; set; }
        public string Item060ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item060 Item060 { get; set; }
        public virtual Order060 Order060 { get; set; }
    }
}
