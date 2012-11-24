using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order006
    {
        public Order006()
        {
            this.OrderLine006 = new List<OrderLine006>();
        }

        public int Order006ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer006ID { get; set; }
        public string Note { get; set; }
        public virtual Customer006 Customer006 { get; set; }
        public virtual ICollection<OrderLine006> OrderLine006 { get; set; }
    }
}
