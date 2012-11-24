using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine029
    {
        public int OrderLine029ID { get; set; }
        public int Order029ID { get; set; }
        public string Item029ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item029 Item029 { get; set; }
        public virtual Order029 Order029 { get; set; }
    }
}
