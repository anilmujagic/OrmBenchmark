using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine072
    {
        public int OrderLine072ID { get; set; }
        public int Order072ID { get; set; }
        public string Item072ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item072 Item072 { get; set; }
        public virtual Order072 Order072 { get; set; }
    }
}
