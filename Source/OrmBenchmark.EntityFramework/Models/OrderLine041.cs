using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine041
    {
        public int OrderLine041ID { get; set; }
        public int Order041ID { get; set; }
        public string Item041ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item041 Item041 { get; set; }
        public virtual Order041 Order041 { get; set; }
    }
}
