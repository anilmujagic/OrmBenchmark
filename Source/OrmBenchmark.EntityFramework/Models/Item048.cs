using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item048
    {
        public Item048()
        {
            this.OrderLine048 = new List<OrderLine048>();
        }

        public string Item048ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine048> OrderLine048 { get; set; }
    }
}
