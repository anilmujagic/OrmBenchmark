using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order049
    {
        public Order049()
        {
            this.OrderLine049 = new List<OrderLine049>();
        }

        public int Order049ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer049ID { get; set; }
        public string Note { get; set; }
        public virtual Customer049 Customer049 { get; set; }
        public virtual ICollection<OrderLine049> OrderLine049 { get; set; }
    }
}
