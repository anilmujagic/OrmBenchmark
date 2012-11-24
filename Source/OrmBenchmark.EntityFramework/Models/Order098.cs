using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order098
    {
        public Order098()
        {
            this.OrderLine098 = new List<OrderLine098>();
        }

        public int Order098ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer098ID { get; set; }
        public string Note { get; set; }
        public virtual Customer098 Customer098 { get; set; }
        public virtual ICollection<OrderLine098> OrderLine098 { get; set; }
    }
}
