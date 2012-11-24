using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item050
    {
        public Item050()
        {
            this.OrderLine050 = new List<OrderLine050>();
        }

        public string Item050ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine050> OrderLine050 { get; set; }
    }
}
