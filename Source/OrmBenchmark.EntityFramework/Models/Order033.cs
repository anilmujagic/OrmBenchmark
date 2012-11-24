using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order033
    {
        public Order033()
        {
            this.OrderLine033 = new List<OrderLine033>();
        }

        public int Order033ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer033ID { get; set; }
        public string Note { get; set; }
        public virtual Customer033 Customer033 { get; set; }
        public virtual ICollection<OrderLine033> OrderLine033 { get; set; }
    }
}
