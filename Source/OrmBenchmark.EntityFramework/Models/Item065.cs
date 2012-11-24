using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item065
    {
        public Item065()
        {
            this.OrderLine065 = new List<OrderLine065>();
        }

        public string Item065ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine065> OrderLine065 { get; set; }
    }
}
