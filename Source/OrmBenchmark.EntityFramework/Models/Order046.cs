using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order046
    {
        public Order046()
        {
            this.OrderLine046 = new List<OrderLine046>();
        }

        public int Order046ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer046ID { get; set; }
        public string Note { get; set; }
        public virtual Customer046 Customer046 { get; set; }
        public virtual ICollection<OrderLine046> OrderLine046 { get; set; }
    }
}
