using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine086
    {
        public int OrderLine086ID { get; set; }
        public int Order086ID { get; set; }
        public string Item086ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item086 Item086 { get; set; }
        public virtual Order086 Order086 { get; set; }
    }
}
