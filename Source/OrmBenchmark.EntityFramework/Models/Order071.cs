using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order071
    {
        public Order071()
        {
            this.OrderLine071 = new List<OrderLine071>();
        }

        public int Order071ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer071ID { get; set; }
        public string Note { get; set; }
        public virtual Customer071 Customer071 { get; set; }
        public virtual ICollection<OrderLine071> OrderLine071 { get; set; }
    }
}
