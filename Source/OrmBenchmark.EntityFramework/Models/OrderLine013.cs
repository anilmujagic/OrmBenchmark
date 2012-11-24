using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine013
    {
        public int OrderLine013ID { get; set; }
        public int Order013ID { get; set; }
        public string Item013ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item013 Item013 { get; set; }
        public virtual Order013 Order013 { get; set; }
    }
}
