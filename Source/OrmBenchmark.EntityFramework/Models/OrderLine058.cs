using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine058
    {
        public int OrderLine058ID { get; set; }
        public int Order058ID { get; set; }
        public string Item058ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item058 Item058 { get; set; }
        public virtual Order058 Order058 { get; set; }
    }
}
