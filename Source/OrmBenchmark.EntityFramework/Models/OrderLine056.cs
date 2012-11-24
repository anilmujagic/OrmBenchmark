using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine056
    {
        public int OrderLine056ID { get; set; }
        public int Order056ID { get; set; }
        public string Item056ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item056 Item056 { get; set; }
        public virtual Order056 Order056 { get; set; }
    }
}
