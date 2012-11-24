using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine067
    {
        public int OrderLine067ID { get; set; }
        public int Order067ID { get; set; }
        public string Item067ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item067 Item067 { get; set; }
        public virtual Order067 Order067 { get; set; }
    }
}
