using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order048
    {
        public Order048()
        {
            this.OrderLine048 = new List<OrderLine048>();
        }

        public int Order048ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer048ID { get; set; }
        public string Note { get; set; }
        public virtual Customer048 Customer048 { get; set; }
        public virtual ICollection<OrderLine048> OrderLine048 { get; set; }
    }
}
