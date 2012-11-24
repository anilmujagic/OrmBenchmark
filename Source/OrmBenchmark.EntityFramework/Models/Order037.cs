using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order037
    {
        public Order037()
        {
            this.OrderLine037 = new List<OrderLine037>();
        }

        public int Order037ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer037ID { get; set; }
        public string Note { get; set; }
        public virtual Customer037 Customer037 { get; set; }
        public virtual ICollection<OrderLine037> OrderLine037 { get; set; }
    }
}
