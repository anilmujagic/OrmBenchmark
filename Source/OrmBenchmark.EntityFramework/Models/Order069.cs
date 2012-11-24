using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order069
    {
        public Order069()
        {
            this.OrderLine069 = new List<OrderLine069>();
        }

        public int Order069ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer069ID { get; set; }
        public string Note { get; set; }
        public virtual Customer069 Customer069 { get; set; }
        public virtual ICollection<OrderLine069> OrderLine069 { get; set; }
    }
}
