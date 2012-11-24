using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine070
    {
        public int OrderLine070ID { get; set; }
        public int Order070ID { get; set; }
        public string Item070ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item070 Item070 { get; set; }
        public virtual Order070 Order070 { get; set; }
    }
}
