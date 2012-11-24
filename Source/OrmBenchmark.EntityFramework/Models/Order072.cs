using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order072
    {
        public Order072()
        {
            this.OrderLine072 = new List<OrderLine072>();
        }

        public int Order072ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer072ID { get; set; }
        public string Note { get; set; }
        public virtual Customer072 Customer072 { get; set; }
        public virtual ICollection<OrderLine072> OrderLine072 { get; set; }
    }
}
