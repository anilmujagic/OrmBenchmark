using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order014
    {
        public Order014()
        {
            this.OrderLine014 = new List<OrderLine014>();
        }

        public int Order014ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer014ID { get; set; }
        public string Note { get; set; }
        public virtual Customer014 Customer014 { get; set; }
        public virtual ICollection<OrderLine014> OrderLine014 { get; set; }
    }
}
