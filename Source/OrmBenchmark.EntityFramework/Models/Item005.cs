using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item005
    {
        public Item005()
        {
            this.OrderLine005 = new List<OrderLine005>();
        }

        public string Item005ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine005> OrderLine005 { get; set; }
    }
}
