using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine011
    {
        public int OrderLine011ID { get; set; }
        public int Order011ID { get; set; }
        public string Item011ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item011 Item011 { get; set; }
        public virtual Order011 Order011 { get; set; }
    }
}
