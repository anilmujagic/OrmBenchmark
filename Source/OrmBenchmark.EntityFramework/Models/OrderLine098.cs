using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine098
    {
        public int OrderLine098ID { get; set; }
        public int Order098ID { get; set; }
        public string Item098ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item098 Item098 { get; set; }
        public virtual Order098 Order098 { get; set; }
    }
}
