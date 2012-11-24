using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item002
    {
        public Item002()
        {
            this.OrderLine002 = new List<OrderLine002>();
        }

        public string Item002ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine002> OrderLine002 { get; set; }
    }
}
