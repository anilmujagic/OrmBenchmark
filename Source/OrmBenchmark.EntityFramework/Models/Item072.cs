using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item072
    {
        public Item072()
        {
            this.OrderLine072 = new List<OrderLine072>();
        }

        public string Item072ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine072> OrderLine072 { get; set; }
    }
}
