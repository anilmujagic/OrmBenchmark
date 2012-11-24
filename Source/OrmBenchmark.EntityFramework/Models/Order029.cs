using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order029
    {
        public Order029()
        {
            this.OrderLine029 = new List<OrderLine029>();
        }

        public int Order029ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer029ID { get; set; }
        public string Note { get; set; }
        public virtual Customer029 Customer029 { get; set; }
        public virtual ICollection<OrderLine029> OrderLine029 { get; set; }
    }
}
