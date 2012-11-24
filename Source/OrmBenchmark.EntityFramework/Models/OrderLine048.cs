using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine048
    {
        public int OrderLine048ID { get; set; }
        public int Order048ID { get; set; }
        public string Item048ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item048 Item048 { get; set; }
        public virtual Order048 Order048 { get; set; }
    }
}
