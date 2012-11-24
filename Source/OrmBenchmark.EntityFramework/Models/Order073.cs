using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order073
    {
        public Order073()
        {
            this.OrderLine073 = new List<OrderLine073>();
        }

        public int Order073ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer073ID { get; set; }
        public string Note { get; set; }
        public virtual Customer073 Customer073 { get; set; }
        public virtual ICollection<OrderLine073> OrderLine073 { get; set; }
    }
}
