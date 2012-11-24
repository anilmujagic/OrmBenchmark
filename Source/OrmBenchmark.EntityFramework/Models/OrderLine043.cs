using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine043
    {
        public int OrderLine043ID { get; set; }
        public int Order043ID { get; set; }
        public string Item043ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item043 Item043 { get; set; }
        public virtual Order043 Order043 { get; set; }
    }
}
