using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order095
    {
        public Order095()
        {
            this.OrderLine095 = new List<OrderLine095>();
        }

        public int Order095ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer095ID { get; set; }
        public string Note { get; set; }
        public virtual Customer095 Customer095 { get; set; }
        public virtual ICollection<OrderLine095> OrderLine095 { get; set; }
    }
}
