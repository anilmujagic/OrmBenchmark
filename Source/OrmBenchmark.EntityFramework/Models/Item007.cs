using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item007
    {
        public Item007()
        {
            this.OrderLine007 = new List<OrderLine007>();
        }

        public string Item007ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine007> OrderLine007 { get; set; }
    }
}
