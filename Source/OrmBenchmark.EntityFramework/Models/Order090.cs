using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order090
    {
        public Order090()
        {
            this.OrderLine090 = new List<OrderLine090>();
        }

        public int Order090ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer090ID { get; set; }
        public string Note { get; set; }
        public virtual Customer090 Customer090 { get; set; }
        public virtual ICollection<OrderLine090> OrderLine090 { get; set; }
    }
}
