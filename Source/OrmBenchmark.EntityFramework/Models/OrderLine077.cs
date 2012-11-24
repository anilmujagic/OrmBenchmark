using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine077
    {
        public int OrderLine077ID { get; set; }
        public int Order077ID { get; set; }
        public string Item077ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item077 Item077 { get; set; }
        public virtual Order077 Order077 { get; set; }
    }
}
