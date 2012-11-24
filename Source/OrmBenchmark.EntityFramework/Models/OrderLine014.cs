using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine014
    {
        public int OrderLine014ID { get; set; }
        public int Order014ID { get; set; }
        public string Item014ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item014 Item014 { get; set; }
        public virtual Order014 Order014 { get; set; }
    }
}
