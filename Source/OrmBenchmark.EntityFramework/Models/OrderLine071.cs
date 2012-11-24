using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine071
    {
        public int OrderLine071ID { get; set; }
        public int Order071ID { get; set; }
        public string Item071ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item071 Item071 { get; set; }
        public virtual Order071 Order071 { get; set; }
    }
}
