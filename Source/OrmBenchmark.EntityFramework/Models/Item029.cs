using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item029
    {
        public Item029()
        {
            this.OrderLine029 = new List<OrderLine029>();
        }

        public string Item029ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine029> OrderLine029 { get; set; }
    }
}
