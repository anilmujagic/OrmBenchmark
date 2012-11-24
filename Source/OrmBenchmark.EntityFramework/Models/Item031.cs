using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item031
    {
        public Item031()
        {
            this.OrderLine031 = new List<OrderLine031>();
        }

        public string Item031ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine031> OrderLine031 { get; set; }
    }
}
