using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order015
    {
        public Order015()
        {
            this.OrderLine015 = new List<OrderLine015>();
        }

        public int Order015ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer015ID { get; set; }
        public string Note { get; set; }
        public virtual Customer015 Customer015 { get; set; }
        public virtual ICollection<OrderLine015> OrderLine015 { get; set; }
    }
}
