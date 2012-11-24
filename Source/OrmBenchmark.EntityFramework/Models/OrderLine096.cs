using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine096
    {
        public int OrderLine096ID { get; set; }
        public int Order096ID { get; set; }
        public string Item096ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item096 Item096 { get; set; }
        public virtual Order096 Order096 { get; set; }
    }
}
