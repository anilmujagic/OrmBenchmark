using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine033
    {
        public int OrderLine033ID { get; set; }
        public int Order033ID { get; set; }
        public string Item033ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item033 Item033 { get; set; }
        public virtual Order033 Order033 { get; set; }
    }
}
