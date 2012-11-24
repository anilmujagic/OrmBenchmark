using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order038
    {
        public Order038()
        {
            this.OrderLine038 = new List<OrderLine038>();
        }

        public int Order038ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer038ID { get; set; }
        public string Note { get; set; }
        public virtual Customer038 Customer038 { get; set; }
        public virtual ICollection<OrderLine038> OrderLine038 { get; set; }
    }
}
