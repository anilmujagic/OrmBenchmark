using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine018
    {
        public int OrderLine018ID { get; set; }
        public int Order018ID { get; set; }
        public string Item018ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item018 Item018 { get; set; }
        public virtual Order018 Order018 { get; set; }
    }
}
