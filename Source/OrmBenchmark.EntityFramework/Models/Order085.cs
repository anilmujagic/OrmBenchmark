using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order085
    {
        public Order085()
        {
            this.OrderLine085 = new List<OrderLine085>();
        }

        public int Order085ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer085ID { get; set; }
        public string Note { get; set; }
        public virtual Customer085 Customer085 { get; set; }
        public virtual ICollection<OrderLine085> OrderLine085 { get; set; }
    }
}
