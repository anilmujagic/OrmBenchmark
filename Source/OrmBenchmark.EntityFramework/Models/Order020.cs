using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order020
    {
        public Order020()
        {
            this.OrderLine020 = new List<OrderLine020>();
        }

        public int Order020ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer020ID { get; set; }
        public string Note { get; set; }
        public virtual Customer020 Customer020 { get; set; }
        public virtual ICollection<OrderLine020> OrderLine020 { get; set; }
    }
}
