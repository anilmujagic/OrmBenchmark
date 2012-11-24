using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine097
    {
        public int OrderLine097ID { get; set; }
        public int Order097ID { get; set; }
        public string Item097ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item097 Item097 { get; set; }
        public virtual Order097 Order097 { get; set; }
    }
}
