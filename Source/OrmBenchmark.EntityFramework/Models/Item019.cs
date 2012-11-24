using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item019
    {
        public Item019()
        {
            this.OrderLine019 = new List<OrderLine019>();
        }

        public string Item019ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine019> OrderLine019 { get; set; }
    }
}
