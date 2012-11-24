using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order021
    {
        public Order021()
        {
            this.OrderLine021 = new List<OrderLine021>();
        }

        public int Order021ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer021ID { get; set; }
        public string Note { get; set; }
        public virtual Customer021 Customer021 { get; set; }
        public virtual ICollection<OrderLine021> OrderLine021 { get; set; }
    }
}
