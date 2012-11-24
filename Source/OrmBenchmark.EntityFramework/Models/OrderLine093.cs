using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine093
    {
        public int OrderLine093ID { get; set; }
        public int Order093ID { get; set; }
        public string Item093ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item093 Item093 { get; set; }
        public virtual Order093 Order093 { get; set; }
    }
}
