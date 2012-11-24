using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order034
    {
        public Order034()
        {
            this.OrderLine034 = new List<OrderLine034>();
        }

        public int Order034ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer034ID { get; set; }
        public string Note { get; set; }
        public virtual Customer034 Customer034 { get; set; }
        public virtual ICollection<OrderLine034> OrderLine034 { get; set; }
    }
}
