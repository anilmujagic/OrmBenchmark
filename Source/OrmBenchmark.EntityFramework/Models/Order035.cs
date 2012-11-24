using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order035
    {
        public Order035()
        {
            this.OrderLine035 = new List<OrderLine035>();
        }

        public int Order035ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer035ID { get; set; }
        public string Note { get; set; }
        public virtual Customer035 Customer035 { get; set; }
        public virtual ICollection<OrderLine035> OrderLine035 { get; set; }
    }
}
