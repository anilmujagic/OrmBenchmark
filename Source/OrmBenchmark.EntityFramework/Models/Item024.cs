using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item024
    {
        public Item024()
        {
            this.OrderLine024 = new List<OrderLine024>();
        }

        public string Item024ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine024> OrderLine024 { get; set; }
    }
}
