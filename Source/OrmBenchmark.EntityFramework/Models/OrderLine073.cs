using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine073
    {
        public int OrderLine073ID { get; set; }
        public int Order073ID { get; set; }
        public string Item073ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item073 Item073 { get; set; }
        public virtual Order073 Order073 { get; set; }
    }
}
