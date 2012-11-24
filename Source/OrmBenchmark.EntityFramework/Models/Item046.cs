using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item046
    {
        public Item046()
        {
            this.OrderLine046 = new List<OrderLine046>();
        }

        public string Item046ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine046> OrderLine046 { get; set; }
    }
}
