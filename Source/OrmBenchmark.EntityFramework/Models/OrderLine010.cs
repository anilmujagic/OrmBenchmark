using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine010
    {
        public int OrderLine010ID { get; set; }
        public int Order010ID { get; set; }
        public string Item010ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item010 Item010 { get; set; }
        public virtual Order010 Order010 { get; set; }
    }
}
