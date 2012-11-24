using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine034
    {
        public int OrderLine034ID { get; set; }
        public int Order034ID { get; set; }
        public string Item034ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item034 Item034 { get; set; }
        public virtual Order034 Order034 { get; set; }
    }
}
