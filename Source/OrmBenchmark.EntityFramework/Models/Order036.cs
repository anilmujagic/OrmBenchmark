using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order036
    {
        public Order036()
        {
            this.OrderLine036 = new List<OrderLine036>();
        }

        public int Order036ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer036ID { get; set; }
        public string Note { get; set; }
        public virtual Customer036 Customer036 { get; set; }
        public virtual ICollection<OrderLine036> OrderLine036 { get; set; }
    }
}
