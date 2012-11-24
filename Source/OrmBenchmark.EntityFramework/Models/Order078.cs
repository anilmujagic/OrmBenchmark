using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order078
    {
        public Order078()
        {
            this.OrderLine078 = new List<OrderLine078>();
        }

        public int Order078ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer078ID { get; set; }
        public string Note { get; set; }
        public virtual Customer078 Customer078 { get; set; }
        public virtual ICollection<OrderLine078> OrderLine078 { get; set; }
    }
}
