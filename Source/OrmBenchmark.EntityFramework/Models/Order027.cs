using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order027
    {
        public Order027()
        {
            this.OrderLine027 = new List<OrderLine027>();
        }

        public int Order027ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer027ID { get; set; }
        public string Note { get; set; }
        public virtual Customer027 Customer027 { get; set; }
        public virtual ICollection<OrderLine027> OrderLine027 { get; set; }
    }
}
