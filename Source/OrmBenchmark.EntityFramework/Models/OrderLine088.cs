using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine088
    {
        public int OrderLine088ID { get; set; }
        public int Order088ID { get; set; }
        public string Item088ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item088 Item088 { get; set; }
        public virtual Order088 Order088 { get; set; }
    }
}
