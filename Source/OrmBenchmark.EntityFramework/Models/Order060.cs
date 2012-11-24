using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order060
    {
        public Order060()
        {
            this.OrderLine060 = new List<OrderLine060>();
        }

        public int Order060ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer060ID { get; set; }
        public string Note { get; set; }
        public virtual Customer060 Customer060 { get; set; }
        public virtual ICollection<OrderLine060> OrderLine060 { get; set; }
    }
}
