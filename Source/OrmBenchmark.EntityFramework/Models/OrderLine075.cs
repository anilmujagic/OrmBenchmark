using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine075
    {
        public int OrderLine075ID { get; set; }
        public int Order075ID { get; set; }
        public string Item075ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item075 Item075 { get; set; }
        public virtual Order075 Order075 { get; set; }
    }
}
