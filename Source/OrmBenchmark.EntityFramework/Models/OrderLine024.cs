using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine024
    {
        public int OrderLine024ID { get; set; }
        public int Order024ID { get; set; }
        public string Item024ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item024 Item024 { get; set; }
        public virtual Order024 Order024 { get; set; }
    }
}
