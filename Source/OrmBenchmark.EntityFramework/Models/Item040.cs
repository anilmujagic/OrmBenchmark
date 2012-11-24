using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item040
    {
        public Item040()
        {
            this.OrderLine040 = new List<OrderLine040>();
        }

        public string Item040ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine040> OrderLine040 { get; set; }
    }
}
