using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine020
    {
        public int OrderLine020ID { get; set; }
        public int Order020ID { get; set; }
        public string Item020ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item020 Item020 { get; set; }
        public virtual Order020 Order020 { get; set; }
    }
}
