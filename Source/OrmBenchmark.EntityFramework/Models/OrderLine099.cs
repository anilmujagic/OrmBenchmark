using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine099
    {
        public int OrderLine099ID { get; set; }
        public int Order099ID { get; set; }
        public string Item099ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item099 Item099 { get; set; }
        public virtual Order099 Order099 { get; set; }
    }
}