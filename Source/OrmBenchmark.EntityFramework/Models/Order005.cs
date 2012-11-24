using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order005
    {
        public Order005()
        {
            this.OrderLine005 = new List<OrderLine005>();
        }

        public int Order005ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer005ID { get; set; }
        public string Note { get; set; }
        public virtual Customer005 Customer005 { get; set; }
        public virtual ICollection<OrderLine005> OrderLine005 { get; set; }
    }
}
