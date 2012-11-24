using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order094
    {
        public Order094()
        {
            this.OrderLine094 = new List<OrderLine094>();
        }

        public int Order094ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer094ID { get; set; }
        public string Note { get; set; }
        public virtual Customer094 Customer094 { get; set; }
        public virtual ICollection<OrderLine094> OrderLine094 { get; set; }
    }
}
