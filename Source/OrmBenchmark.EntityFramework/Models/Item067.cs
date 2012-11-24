using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item067
    {
        public Item067()
        {
            this.OrderLine067 = new List<OrderLine067>();
        }

        public string Item067ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine067> OrderLine067 { get; set; }
    }
}
