using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item066
    {
        public Item066()
        {
            this.OrderLine066 = new List<OrderLine066>();
        }

        public string Item066ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine066> OrderLine066 { get; set; }
    }
}
