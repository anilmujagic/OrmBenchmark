using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine061
    {
        public int OrderLine061ID { get; set; }
        public int Order061ID { get; set; }
        public string Item061ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item061 Item061 { get; set; }
        public virtual Order061 Order061 { get; set; }
    }
}
