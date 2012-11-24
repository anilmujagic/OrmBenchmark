using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item014
    {
        public Item014()
        {
            this.OrderLine014 = new List<OrderLine014>();
        }

        public string Item014ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine014> OrderLine014 { get; set; }
    }
}
