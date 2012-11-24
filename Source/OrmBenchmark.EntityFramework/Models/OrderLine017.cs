using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine017
    {
        public int OrderLine017ID { get; set; }
        public int Order017ID { get; set; }
        public string Item017ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item017 Item017 { get; set; }
        public virtual Order017 Order017 { get; set; }
    }
}
