using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine031
    {
        public int OrderLine031ID { get; set; }
        public int Order031ID { get; set; }
        public string Item031ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item031 Item031 { get; set; }
        public virtual Order031 Order031 { get; set; }
    }
}
