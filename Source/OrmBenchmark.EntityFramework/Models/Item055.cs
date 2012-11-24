using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item055
    {
        public Item055()
        {
            this.OrderLine055 = new List<OrderLine055>();
        }

        public string Item055ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine055> OrderLine055 { get; set; }
    }
}
