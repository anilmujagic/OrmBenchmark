using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine087
    {
        public int OrderLine087ID { get; set; }
        public int Order087ID { get; set; }
        public string Item087ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item087 Item087 { get; set; }
        public virtual Order087 Order087 { get; set; }
    }
}
