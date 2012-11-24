using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item097
    {
        public Item097()
        {
            this.OrderLine097 = new List<OrderLine097>();
        }

        public string Item097ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine097> OrderLine097 { get; set; }
    }
}
