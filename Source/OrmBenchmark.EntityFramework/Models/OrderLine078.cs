using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine078
    {
        public int OrderLine078ID { get; set; }
        public int Order078ID { get; set; }
        public string Item078ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item078 Item078 { get; set; }
        public virtual Order078 Order078 { get; set; }
    }
}
