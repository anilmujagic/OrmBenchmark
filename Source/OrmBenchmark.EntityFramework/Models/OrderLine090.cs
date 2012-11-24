using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine090
    {
        public int OrderLine090ID { get; set; }
        public int Order090ID { get; set; }
        public string Item090ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item090 Item090 { get; set; }
        public virtual Order090 Order090 { get; set; }
    }
}
