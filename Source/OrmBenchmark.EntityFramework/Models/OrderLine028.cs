using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine028
    {
        public int OrderLine028ID { get; set; }
        public int Order028ID { get; set; }
        public string Item028ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item028 Item028 { get; set; }
        public virtual Order028 Order028 { get; set; }
    }
}
