using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine005
    {
        public int OrderLine005ID { get; set; }
        public int Order005ID { get; set; }
        public string Item005ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item005 Item005 { get; set; }
        public virtual Order005 Order005 { get; set; }
    }
}
