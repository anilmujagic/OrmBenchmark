using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order080
    {
        public Order080()
        {
            this.OrderLine080 = new List<OrderLine080>();
        }

        public int Order080ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer080ID { get; set; }
        public string Note { get; set; }
        public virtual Customer080 Customer080 { get; set; }
        public virtual ICollection<OrderLine080> OrderLine080 { get; set; }
    }
}
