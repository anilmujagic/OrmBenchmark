using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine068
    {
        public int OrderLine068ID { get; set; }
        public int Order068ID { get; set; }
        public string Item068ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item068 Item068 { get; set; }
        public virtual Order068 Order068 { get; set; }
    }
}
