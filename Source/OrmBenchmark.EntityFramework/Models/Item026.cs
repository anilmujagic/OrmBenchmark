using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item026
    {
        public Item026()
        {
            this.OrderLine026 = new List<OrderLine026>();
        }

        public string Item026ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine026> OrderLine026 { get; set; }
    }
}
