using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine008
    {
        public int OrderLine008ID { get; set; }
        public int Order008ID { get; set; }
        public string Item008ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item008 Item008 { get; set; }
        public virtual Order008 Order008 { get; set; }
    }
}
