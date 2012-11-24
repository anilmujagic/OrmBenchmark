using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item077
    {
        public Item077()
        {
            this.OrderLine077 = new List<OrderLine077>();
        }

        public string Item077ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine077> OrderLine077 { get; set; }
    }
}
