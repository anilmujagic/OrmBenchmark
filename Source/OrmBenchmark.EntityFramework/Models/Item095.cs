using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item095
    {
        public Item095()
        {
            this.OrderLine095 = new List<OrderLine095>();
        }

        public string Item095ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine095> OrderLine095 { get; set; }
    }
}
