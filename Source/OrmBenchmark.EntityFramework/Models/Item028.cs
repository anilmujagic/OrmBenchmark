using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item028
    {
        public Item028()
        {
            this.OrderLine028 = new List<OrderLine028>();
        }

        public string Item028ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine028> OrderLine028 { get; set; }
    }
}
