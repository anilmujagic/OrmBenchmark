using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item020
    {
        public Item020()
        {
            this.OrderLine020 = new List<OrderLine020>();
        }

        public string Item020ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine020> OrderLine020 { get; set; }
    }
}
