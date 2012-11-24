using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order077
    {
        public Order077()
        {
            this.OrderLine077 = new List<OrderLine077>();
        }

        public int Order077ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer077ID { get; set; }
        public string Note { get; set; }
        public virtual Customer077 Customer077 { get; set; }
        public virtual ICollection<OrderLine077> OrderLine077 { get; set; }
    }
}
