using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item085
    {
        public Item085()
        {
            this.OrderLine085 = new List<OrderLine085>();
        }

        public string Item085ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine085> OrderLine085 { get; set; }
    }
}
