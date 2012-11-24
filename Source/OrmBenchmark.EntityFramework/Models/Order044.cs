using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order044
    {
        public Order044()
        {
            this.OrderLine044 = new List<OrderLine044>();
        }

        public int Order044ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer044ID { get; set; }
        public string Note { get; set; }
        public virtual Customer044 Customer044 { get; set; }
        public virtual ICollection<OrderLine044> OrderLine044 { get; set; }
    }
}
