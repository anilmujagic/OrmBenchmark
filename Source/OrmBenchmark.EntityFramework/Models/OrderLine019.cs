using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine019
    {
        public int OrderLine019ID { get; set; }
        public int Order019ID { get; set; }
        public string Item019ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item019 Item019 { get; set; }
        public virtual Order019 Order019 { get; set; }
    }
}
