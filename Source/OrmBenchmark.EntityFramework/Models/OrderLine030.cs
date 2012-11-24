using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine030
    {
        public int OrderLine030ID { get; set; }
        public int Order030ID { get; set; }
        public string Item030ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item030 Item030 { get; set; }
        public virtual Order030 Order030 { get; set; }
    }
}
