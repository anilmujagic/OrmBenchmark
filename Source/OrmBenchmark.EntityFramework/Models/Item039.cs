using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item039
    {
        public Item039()
        {
            this.OrderLine039 = new List<OrderLine039>();
        }

        public string Item039ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine039> OrderLine039 { get; set; }
    }
}
