using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine057
    {
        public int OrderLine057ID { get; set; }
        public int Order057ID { get; set; }
        public string Item057ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item057 Item057 { get; set; }
        public virtual Order057 Order057 { get; set; }
    }
}
