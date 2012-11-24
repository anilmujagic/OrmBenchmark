using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine022
    {
        public int OrderLine022ID { get; set; }
        public int Order022ID { get; set; }
        public string Item022ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item022 Item022 { get; set; }
        public virtual Order022 Order022 { get; set; }
    }
}
