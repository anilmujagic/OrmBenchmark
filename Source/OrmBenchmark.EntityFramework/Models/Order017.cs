using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order017
    {
        public Order017()
        {
            this.OrderLine017 = new List<OrderLine017>();
        }

        public int Order017ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer017ID { get; set; }
        public string Note { get; set; }
        public virtual Customer017 Customer017 { get; set; }
        public virtual ICollection<OrderLine017> OrderLine017 { get; set; }
    }
}
