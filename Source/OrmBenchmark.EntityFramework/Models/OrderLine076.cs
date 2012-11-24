using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine076
    {
        public int OrderLine076ID { get; set; }
        public int Order076ID { get; set; }
        public string Item076ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item076 Item076 { get; set; }
        public virtual Order076 Order076 { get; set; }
    }
}
