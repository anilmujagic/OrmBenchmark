using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine055
    {
        public int OrderLine055ID { get; set; }
        public int Order055ID { get; set; }
        public string Item055ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item055 Item055 { get; set; }
        public virtual Order055 Order055 { get; set; }
    }
}
