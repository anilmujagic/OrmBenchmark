using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine015
    {
        public int OrderLine015ID { get; set; }
        public int Order015ID { get; set; }
        public string Item015ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item015 Item015 { get; set; }
        public virtual Order015 Order015 { get; set; }
    }
}
