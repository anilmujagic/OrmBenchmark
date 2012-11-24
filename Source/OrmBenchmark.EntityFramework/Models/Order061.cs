using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order061
    {
        public Order061()
        {
            this.OrderLine061 = new List<OrderLine061>();
        }

        public int Order061ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer061ID { get; set; }
        public string Note { get; set; }
        public virtual Customer061 Customer061 { get; set; }
        public virtual ICollection<OrderLine061> OrderLine061 { get; set; }
    }
}
