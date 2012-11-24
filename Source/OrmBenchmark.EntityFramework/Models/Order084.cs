using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order084
    {
        public Order084()
        {
            this.OrderLine084 = new List<OrderLine084>();
        }

        public int Order084ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer084ID { get; set; }
        public string Note { get; set; }
        public virtual Customer084 Customer084 { get; set; }
        public virtual ICollection<OrderLine084> OrderLine084 { get; set; }
    }
}
