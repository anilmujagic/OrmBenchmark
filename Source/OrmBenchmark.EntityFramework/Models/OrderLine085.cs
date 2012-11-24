using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine085
    {
        public int OrderLine085ID { get; set; }
        public int Order085ID { get; set; }
        public string Item085ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item085 Item085 { get; set; }
        public virtual Order085 Order085 { get; set; }
    }
}
