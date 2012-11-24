using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine038
    {
        public int OrderLine038ID { get; set; }
        public int Order038ID { get; set; }
        public string Item038ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item038 Item038 { get; set; }
        public virtual Order038 Order038 { get; set; }
    }
}
