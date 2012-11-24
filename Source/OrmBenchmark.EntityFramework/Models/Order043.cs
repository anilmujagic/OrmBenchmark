using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order043
    {
        public Order043()
        {
            this.OrderLine043 = new List<OrderLine043>();
        }

        public int Order043ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer043ID { get; set; }
        public string Note { get; set; }
        public virtual Customer043 Customer043 { get; set; }
        public virtual ICollection<OrderLine043> OrderLine043 { get; set; }
    }
}
