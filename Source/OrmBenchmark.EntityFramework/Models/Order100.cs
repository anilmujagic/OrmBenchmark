using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order100
    {
        public Order100()
        {
            this.OrderLine100 = new List<OrderLine100>();
        }

        public int Order100ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer100ID { get; set; }
        public string Note { get; set; }
        public virtual Customer100 Customer100 { get; set; }
        public virtual ICollection<OrderLine100> OrderLine100 { get; set; }
    }
}
