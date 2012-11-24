using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine080
    {
        public int OrderLine080ID { get; set; }
        public int Order080ID { get; set; }
        public string Item080ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item080 Item080 { get; set; }
        public virtual Order080 Order080 { get; set; }
    }
}
