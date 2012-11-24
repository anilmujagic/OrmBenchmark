using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine021
    {
        public int OrderLine021ID { get; set; }
        public int Order021ID { get; set; }
        public string Item021ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item021 Item021 { get; set; }
        public virtual Order021 Order021 { get; set; }
    }
}
