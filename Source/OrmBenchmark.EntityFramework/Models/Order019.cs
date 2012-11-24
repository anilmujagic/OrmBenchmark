using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order019
    {
        public Order019()
        {
            this.OrderLine019 = new List<OrderLine019>();
        }

        public int Order019ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer019ID { get; set; }
        public string Note { get; set; }
        public virtual Customer019 Customer019 { get; set; }
        public virtual ICollection<OrderLine019> OrderLine019 { get; set; }
    }
}
