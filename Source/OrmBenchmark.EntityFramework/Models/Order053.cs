using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order053
    {
        public Order053()
        {
            this.OrderLine053 = new List<OrderLine053>();
        }

        public int Order053ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer053ID { get; set; }
        public string Note { get; set; }
        public virtual Customer053 Customer053 { get; set; }
        public virtual ICollection<OrderLine053> OrderLine053 { get; set; }
    }
}
