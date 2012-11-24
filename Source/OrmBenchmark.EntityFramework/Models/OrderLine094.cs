using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine094
    {
        public int OrderLine094ID { get; set; }
        public int Order094ID { get; set; }
        public string Item094ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item094 Item094 { get; set; }
        public virtual Order094 Order094 { get; set; }
    }
}
