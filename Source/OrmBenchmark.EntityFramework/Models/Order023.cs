using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order023
    {
        public Order023()
        {
            this.OrderLine023 = new List<OrderLine023>();
        }

        public int Order023ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer023ID { get; set; }
        public string Note { get; set; }
        public virtual Customer023 Customer023 { get; set; }
        public virtual ICollection<OrderLine023> OrderLine023 { get; set; }
    }
}
