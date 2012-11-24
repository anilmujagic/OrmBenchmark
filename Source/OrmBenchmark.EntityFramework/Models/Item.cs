using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item
    {
        public Item()
        {
            this.OrderLines = new List<OrderLine>();
        }

        public string ItemID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
