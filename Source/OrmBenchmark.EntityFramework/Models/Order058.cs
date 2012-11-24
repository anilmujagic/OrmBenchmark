using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order058
    {
        public Order058()
        {
            this.OrderLine058 = new List<OrderLine058>();
        }

        public int Order058ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer058ID { get; set; }
        public string Note { get; set; }
        public virtual Customer058 Customer058 { get; set; }
        public virtual ICollection<OrderLine058> OrderLine058 { get; set; }
    }
}
