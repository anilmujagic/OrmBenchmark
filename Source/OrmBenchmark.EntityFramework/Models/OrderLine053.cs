using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine053
    {
        public int OrderLine053ID { get; set; }
        public int Order053ID { get; set; }
        public string Item053ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item053 Item053 { get; set; }
        public virtual Order053 Order053 { get; set; }
    }
}
