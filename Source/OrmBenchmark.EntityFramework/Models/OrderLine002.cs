using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine002
    {
        public int OrderLine002ID { get; set; }
        public int Order002ID { get; set; }
        public string Item002ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item002 Item002 { get; set; }
        public virtual Order002 Order002 { get; set; }
    }
}
