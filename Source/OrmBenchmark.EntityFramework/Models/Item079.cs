using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item079
    {
        public Item079()
        {
            this.OrderLine079 = new List<OrderLine079>();
        }

        public string Item079ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine079> OrderLine079 { get; set; }
    }
}
