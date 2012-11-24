using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order096
    {
        public Order096()
        {
            this.OrderLine096 = new List<OrderLine096>();
        }

        public int Order096ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer096ID { get; set; }
        public string Note { get; set; }
        public virtual Customer096 Customer096 { get; set; }
        public virtual ICollection<OrderLine096> OrderLine096 { get; set; }
    }
}
