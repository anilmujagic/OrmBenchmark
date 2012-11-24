using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item045
    {
        public Item045()
        {
            this.OrderLine045 = new List<OrderLine045>();
        }

        public string Item045ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine045> OrderLine045 { get; set; }
    }
}
