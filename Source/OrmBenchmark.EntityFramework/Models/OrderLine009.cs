using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class OrderLine009
    {
        public int OrderLine009ID { get; set; }
        public int Order009ID { get; set; }
        public string Item009ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Item009 Item009 { get; set; }
        public virtual Order009 Order009 { get; set; }
    }
}
