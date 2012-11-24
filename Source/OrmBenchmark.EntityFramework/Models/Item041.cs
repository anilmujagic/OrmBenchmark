using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item041
    {
        public Item041()
        {
            this.OrderLine041 = new List<OrderLine041>();
        }

        public string Item041ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine041> OrderLine041 { get; set; }
    }
}
