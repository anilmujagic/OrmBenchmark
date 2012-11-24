using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine032
    {
        public int OrderLine032ID { get; set; }
        public int Order032ID { get; set; }
        public string Item032ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item032 Item032 { get; set; }
        public virtual Order032 Order032 { get; set; }
    }
}
