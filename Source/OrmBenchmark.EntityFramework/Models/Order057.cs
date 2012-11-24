using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order057
    {
        public Order057()
        {
            this.OrderLine057 = new List<OrderLine057>();
        }

        public int Order057ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer057ID { get; set; }
        public string Note { get; set; }
        public virtual Customer057 Customer057 { get; set; }
        public virtual ICollection<OrderLine057> OrderLine057 { get; set; }
    }
}
