using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order062
    {
        public Order062()
        {
            this.OrderLine062 = new List<OrderLine062>();
        }

        public int Order062ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer062ID { get; set; }
        public string Note { get; set; }
        public virtual Customer062 Customer062 { get; set; }
        public virtual ICollection<OrderLine062> OrderLine062 { get; set; }
    }
}
