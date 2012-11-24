using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order030
    {
        public Order030()
        {
            this.OrderLine030 = new List<OrderLine030>();
        }

        public int Order030ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer030ID { get; set; }
        public string Note { get; set; }
        public virtual Customer030 Customer030 { get; set; }
        public virtual ICollection<OrderLine030> OrderLine030 { get; set; }
    }
}
