using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine049
    {
        public int OrderLine049ID { get; set; }
        public int Order049ID { get; set; }
        public string Item049ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item049 Item049 { get; set; }
        public virtual Order049 Order049 { get; set; }
    }
}
