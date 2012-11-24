using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item071
    {
        public Item071()
        {
            this.OrderLine071 = new List<OrderLine071>();
        }

        public string Item071ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine071> OrderLine071 { get; set; }
    }
}
