using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item082
    {
        public Item082()
        {
            this.OrderLine082 = new List<OrderLine082>();
        }

        public string Item082ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine082> OrderLine082 { get; set; }
    }
}
