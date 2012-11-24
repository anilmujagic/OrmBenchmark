using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine062
    {
        public int OrderLine062ID { get; set; }
        public int Order062ID { get; set; }
        public string Item062ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item062 Item062 { get; set; }
        public virtual Order062 Order062 { get; set; }
    }
}
