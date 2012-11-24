using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order010
    {
        public Order010()
        {
            this.OrderLine010 = new List<OrderLine010>();
        }

        public int Order010ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer010ID { get; set; }
        public string Note { get; set; }
        public virtual Customer010 Customer010 { get; set; }
        public virtual ICollection<OrderLine010> OrderLine010 { get; set; }
    }
}
