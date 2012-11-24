using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine064
    {
        public int OrderLine064ID { get; set; }
        public int Order064ID { get; set; }
        public string Item064ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item064 Item064 { get; set; }
        public virtual Order064 Order064 { get; set; }
    }
}
