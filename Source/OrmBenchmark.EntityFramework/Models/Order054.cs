using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order054
    {
        public Order054()
        {
            this.OrderLine054 = new List<OrderLine054>();
        }

        public int Order054ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer054ID { get; set; }
        public string Note { get; set; }
        public virtual Customer054 Customer054 { get; set; }
        public virtual ICollection<OrderLine054> OrderLine054 { get; set; }
    }
}
