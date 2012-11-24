using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item088
    {
        public Item088()
        {
            this.OrderLine088 = new List<OrderLine088>();
        }

        public string Item088ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine088> OrderLine088 { get; set; }
    }
}
