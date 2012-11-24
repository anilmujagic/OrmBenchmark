using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine082
    {
        public int OrderLine082ID { get; set; }
        public int Order082ID { get; set; }
        public string Item082ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item082 Item082 { get; set; }
        public virtual Order082 Order082 { get; set; }
    }
}
