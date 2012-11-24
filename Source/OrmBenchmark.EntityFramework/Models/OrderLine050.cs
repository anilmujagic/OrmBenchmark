using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine050
    {
        public int OrderLine050ID { get; set; }
        public int Order050ID { get; set; }
        public string Item050ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item050 Item050 { get; set; }
        public virtual Order050 Order050 { get; set; }
    }
}
