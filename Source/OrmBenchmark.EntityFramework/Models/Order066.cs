using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order066
    {
        public Order066()
        {
            this.OrderLine066 = new List<OrderLine066>();
        }

        public int Order066ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer066ID { get; set; }
        public string Note { get; set; }
        public virtual Customer066 Customer066 { get; set; }
        public virtual ICollection<OrderLine066> OrderLine066 { get; set; }
    }
}
