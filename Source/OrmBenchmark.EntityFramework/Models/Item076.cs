using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item076
    {
        public Item076()
        {
            this.OrderLine076 = new List<OrderLine076>();
        }

        public string Item076ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine076> OrderLine076 { get; set; }
    }
}
