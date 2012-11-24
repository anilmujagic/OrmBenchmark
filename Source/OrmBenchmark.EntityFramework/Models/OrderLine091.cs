using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine091
    {
        public int OrderLine091ID { get; set; }
        public int Order091ID { get; set; }
        public string Item091ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item091 Item091 { get; set; }
        public virtual Order091 Order091 { get; set; }
    }
}
