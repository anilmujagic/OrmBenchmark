using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine052
    {
        public int OrderLine052ID { get; set; }
        public int Order052ID { get; set; }
        public string Item052ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item052 Item052 { get; set; }
        public virtual Order052 Order052 { get; set; }
    }
}
