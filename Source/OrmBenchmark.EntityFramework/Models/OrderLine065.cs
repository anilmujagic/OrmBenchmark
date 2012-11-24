using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine065
    {
        public int OrderLine065ID { get; set; }
        public int Order065ID { get; set; }
        public string Item065ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item065 Item065 { get; set; }
        public virtual Order065 Order065 { get; set; }
    }
}
