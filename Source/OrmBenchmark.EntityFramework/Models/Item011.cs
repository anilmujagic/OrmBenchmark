using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item011
    {
        public Item011()
        {
            this.OrderLine011 = new List<OrderLine011>();
        }

        public string Item011ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine011> OrderLine011 { get; set; }
    }
}
