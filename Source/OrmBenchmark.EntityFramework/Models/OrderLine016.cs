using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine016
    {
        public int OrderLine016ID { get; set; }
        public int Order016ID { get; set; }
        public string Item016ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item016 Item016 { get; set; }
        public virtual Order016 Order016 { get; set; }
    }
}
