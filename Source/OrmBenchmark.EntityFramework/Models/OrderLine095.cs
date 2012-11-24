using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine095
    {
        public int OrderLine095ID { get; set; }
        public int Order095ID { get; set; }
        public string Item095ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item095 Item095 { get; set; }
        public virtual Order095 Order095 { get; set; }
    }
}
