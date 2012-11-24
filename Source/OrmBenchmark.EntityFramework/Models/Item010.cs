using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item010
    {
        public Item010()
        {
            this.OrderLine010 = new List<OrderLine010>();
        }

        public string Item010ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine010> OrderLine010 { get; set; }
    }
}
