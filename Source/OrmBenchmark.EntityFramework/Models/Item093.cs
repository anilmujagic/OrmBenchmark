using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item093
    {
        public Item093()
        {
            this.OrderLine093 = new List<OrderLine093>();
        }

        public string Item093ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine093> OrderLine093 { get; set; }
    }
}
