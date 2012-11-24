using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order028
    {
        public Order028()
        {
            this.OrderLine028 = new List<OrderLine028>();
        }

        public int Order028ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer028ID { get; set; }
        public string Note { get; set; }
        public virtual Customer028 Customer028 { get; set; }
        public virtual ICollection<OrderLine028> OrderLine028 { get; set; }
    }
}
