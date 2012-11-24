using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order041
    {
        public Order041()
        {
            this.OrderLine041 = new List<OrderLine041>();
        }

        public int Order041ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer041ID { get; set; }
        public string Note { get; set; }
        public virtual Customer041 Customer041 { get; set; }
        public virtual ICollection<OrderLine041> OrderLine041 { get; set; }
    }
}
