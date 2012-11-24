using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine003
    {
        public int OrderLine003ID { get; set; }
        public int Order003ID { get; set; }
        public string Item003ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item003 Item003 { get; set; }
        public virtual Order003 Order003 { get; set; }
    }
}
