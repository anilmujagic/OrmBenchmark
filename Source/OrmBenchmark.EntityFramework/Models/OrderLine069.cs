using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine069
    {
        public int OrderLine069ID { get; set; }
        public int Order069ID { get; set; }
        public string Item069ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item069 Item069 { get; set; }
        public virtual Order069 Order069 { get; set; }
    }
}
