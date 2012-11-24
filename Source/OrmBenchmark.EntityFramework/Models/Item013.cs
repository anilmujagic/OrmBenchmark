using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item013
    {
        public Item013()
        {
            this.OrderLine013 = new List<OrderLine013>();
        }

        public string Item013ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine013> OrderLine013 { get; set; }
    }
}
