using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item023
    {
        public Item023()
        {
            this.OrderLine023 = new List<OrderLine023>();
        }

        public string Item023ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine023> OrderLine023 { get; set; }
    }
}
