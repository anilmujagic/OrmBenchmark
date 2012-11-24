using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order024
    {
        public Order024()
        {
            this.OrderLine024 = new List<OrderLine024>();
        }

        public int Order024ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer024ID { get; set; }
        public string Note { get; set; }
        public virtual Customer024 Customer024 { get; set; }
        public virtual ICollection<OrderLine024> OrderLine024 { get; set; }
    }
}
