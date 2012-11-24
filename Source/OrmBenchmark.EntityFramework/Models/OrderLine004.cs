using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine004
    {
        public int OrderLine004ID { get; set; }
        public int Order004ID { get; set; }
        public string Item004ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item004 Item004 { get; set; }
        public virtual Order004 Order004 { get; set; }
    }
}
