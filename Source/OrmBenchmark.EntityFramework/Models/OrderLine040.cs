using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine040
    {
        public int OrderLine040ID { get; set; }
        public int Order040ID { get; set; }
        public string Item040ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item040 Item040 { get; set; }
        public virtual Order040 Order040 { get; set; }
    }
}
