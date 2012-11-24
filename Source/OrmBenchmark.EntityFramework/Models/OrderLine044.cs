using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine044
    {
        public int OrderLine044ID { get; set; }
        public int Order044ID { get; set; }
        public string Item044ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item044 Item044 { get; set; }
        public virtual Order044 Order044 { get; set; }
    }
}
