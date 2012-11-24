using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order011
    {
        public Order011()
        {
            this.OrderLine011 = new List<OrderLine011>();
        }

        public int Order011ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer011ID { get; set; }
        public string Note { get; set; }
        public virtual Customer011 Customer011 { get; set; }
        public virtual ICollection<OrderLine011> OrderLine011 { get; set; }
    }
}
