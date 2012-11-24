using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item027
    {
        public Item027()
        {
            this.OrderLine027 = new List<OrderLine027>();
        }

        public string Item027ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine027> OrderLine027 { get; set; }
    }
}
