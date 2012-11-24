using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order063
    {
        public Order063()
        {
            this.OrderLine063 = new List<OrderLine063>();
        }

        public int Order063ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer063ID { get; set; }
        public string Note { get; set; }
        public virtual Customer063 Customer063 { get; set; }
        public virtual ICollection<OrderLine063> OrderLine063 { get; set; }
    }
}
