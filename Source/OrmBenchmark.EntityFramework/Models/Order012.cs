using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order012
    {
        public Order012()
        {
            this.OrderLine012 = new List<OrderLine012>();
        }

        public int Order012ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer012ID { get; set; }
        public string Note { get; set; }
        public virtual Customer012 Customer012 { get; set; }
        public virtual ICollection<OrderLine012> OrderLine012 { get; set; }
    }
}
