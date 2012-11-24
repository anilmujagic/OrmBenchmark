using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item021
    {
        public Item021()
        {
            this.OrderLine021 = new List<OrderLine021>();
        }

        public string Item021ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine021> OrderLine021 { get; set; }
    }
}
