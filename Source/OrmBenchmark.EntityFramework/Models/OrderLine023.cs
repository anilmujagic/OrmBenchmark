using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine023
    {
        public int OrderLine023ID { get; set; }
        public int Order023ID { get; set; }
        public string Item023ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item023 Item023 { get; set; }
        public virtual Order023 Order023 { get; set; }
    }
}
