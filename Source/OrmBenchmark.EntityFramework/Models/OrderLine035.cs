using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine035
    {
        public int OrderLine035ID { get; set; }
        public int Order035ID { get; set; }
        public string Item035ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item035 Item035 { get; set; }
        public virtual Order035 Order035 { get; set; }
    }
}
