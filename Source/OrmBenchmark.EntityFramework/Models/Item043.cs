using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item043
    {
        public Item043()
        {
            this.OrderLine043 = new List<OrderLine043>();
        }

        public string Item043ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine043> OrderLine043 { get; set; }
    }
}
