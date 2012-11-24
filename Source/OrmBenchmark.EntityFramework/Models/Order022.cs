using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order022
    {
        public Order022()
        {
            this.OrderLine022 = new List<OrderLine022>();
        }

        public int Order022ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer022ID { get; set; }
        public string Note { get; set; }
        public virtual Customer022 Customer022 { get; set; }
        public virtual ICollection<OrderLine022> OrderLine022 { get; set; }
    }
}
