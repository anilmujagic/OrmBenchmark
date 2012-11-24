using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item036
    {
        public Item036()
        {
            this.OrderLine036 = new List<OrderLine036>();
        }

        public string Item036ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine036> OrderLine036 { get; set; }
    }
}
