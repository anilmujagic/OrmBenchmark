using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order013
    {
        public Order013()
        {
            this.OrderLine013 = new List<OrderLine013>();
        }

        public int Order013ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer013ID { get; set; }
        public string Note { get; set; }
        public virtual Customer013 Customer013 { get; set; }
        public virtual ICollection<OrderLine013> OrderLine013 { get; set; }
    }
}
