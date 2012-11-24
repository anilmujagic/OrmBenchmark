using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order009
    {
        public Order009()
        {
            this.OrderLine009 = new List<OrderLine009>();
        }

        public int Order009ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer009ID { get; set; }
        public string Note { get; set; }
        public virtual Customer009 Customer009 { get; set; }
        public virtual ICollection<OrderLine009> OrderLine009 { get; set; }
    }
}
