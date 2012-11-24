using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine081
    {
        public int OrderLine081ID { get; set; }
        public int Order081ID { get; set; }
        public string Item081ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item081 Item081 { get; set; }
        public virtual Order081 Order081 { get; set; }
    }
}
