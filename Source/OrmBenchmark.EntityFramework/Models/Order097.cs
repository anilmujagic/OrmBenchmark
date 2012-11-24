using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order097
    {
        public Order097()
        {
            this.OrderLine097 = new List<OrderLine097>();
        }

        public int Order097ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer097ID { get; set; }
        public string Note { get; set; }
        public virtual Customer097 Customer097 { get; set; }
        public virtual ICollection<OrderLine097> OrderLine097 { get; set; }
    }
}
