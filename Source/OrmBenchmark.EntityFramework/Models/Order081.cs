using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order081
    {
        public Order081()
        {
            this.OrderLine081 = new List<OrderLine081>();
        }

        public int Order081ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer081ID { get; set; }
        public string Note { get; set; }
        public virtual Customer081 Customer081 { get; set; }
        public virtual ICollection<OrderLine081> OrderLine081 { get; set; }
    }
}
