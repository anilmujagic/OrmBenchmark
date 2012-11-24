using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order091
    {
        public Order091()
        {
            this.OrderLine091 = new List<OrderLine091>();
        }

        public int Order091ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer091ID { get; set; }
        public string Note { get; set; }
        public virtual Customer091 Customer091 { get; set; }
        public virtual ICollection<OrderLine091> OrderLine091 { get; set; }
    }
}
