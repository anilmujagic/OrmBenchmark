using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item068
    {
        public Item068()
        {
            this.OrderLine068 = new List<OrderLine068>();
        }

        public string Item068ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine068> OrderLine068 { get; set; }
    }
}
