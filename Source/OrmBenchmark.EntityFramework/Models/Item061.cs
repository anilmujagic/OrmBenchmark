using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item061
    {
        public Item061()
        {
            this.OrderLine061 = new List<OrderLine061>();
        }

        public string Item061ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine061> OrderLine061 { get; set; }
    }
}
