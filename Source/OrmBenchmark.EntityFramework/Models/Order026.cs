using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order026
    {
        public Order026()
        {
            this.OrderLine026 = new List<OrderLine026>();
        }

        public int Order026ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer026ID { get; set; }
        public string Note { get; set; }
        public virtual Customer026 Customer026 { get; set; }
        public virtual ICollection<OrderLine026> OrderLine026 { get; set; }
    }
}
