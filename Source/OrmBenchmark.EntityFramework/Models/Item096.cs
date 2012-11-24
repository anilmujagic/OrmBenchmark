using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item096
    {
        public Item096()
        {
            this.OrderLine096 = new List<OrderLine096>();
        }

        public string Item096ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine096> OrderLine096 { get; set; }
    }
}
