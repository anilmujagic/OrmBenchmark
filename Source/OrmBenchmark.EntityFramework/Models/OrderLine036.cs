using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine036
    {
        public int OrderLine036ID { get; set; }
        public int Order036ID { get; set; }
        public string Item036ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item036 Item036 { get; set; }
        public virtual Order036 Order036 { get; set; }
    }
}
