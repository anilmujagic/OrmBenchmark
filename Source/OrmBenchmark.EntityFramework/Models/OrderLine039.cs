using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine039
    {
        public int OrderLine039ID { get; set; }
        public int Order039ID { get; set; }
        public string Item039ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item039 Item039 { get; set; }
        public virtual Order039 Order039 { get; set; }
    }
}
