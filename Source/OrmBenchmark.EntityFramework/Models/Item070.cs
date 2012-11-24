using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item070
    {
        public Item070()
        {
            this.OrderLine070 = new List<OrderLine070>();
        }

        public string Item070ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine070> OrderLine070 { get; set; }
    }
}
