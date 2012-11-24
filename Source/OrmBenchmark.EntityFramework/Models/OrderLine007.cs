using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine007
    {
        public int OrderLine007ID { get; set; }
        public int Order007ID { get; set; }
        public string Item007ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item007 Item007 { get; set; }
        public virtual Order007 Order007 { get; set; }
    }
}
