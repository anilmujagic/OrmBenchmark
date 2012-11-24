using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item016
    {
        public Item016()
        {
            this.OrderLine016 = new List<OrderLine016>();
        }

        public string Item016ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine016> OrderLine016 { get; set; }
    }
}
