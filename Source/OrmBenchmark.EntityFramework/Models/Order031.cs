using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order031
    {
        public Order031()
        {
            this.OrderLine031 = new List<OrderLine031>();
        }

        public int Order031ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer031ID { get; set; }
        public string Note { get; set; }
        public virtual Customer031 Customer031 { get; set; }
        public virtual ICollection<OrderLine031> OrderLine031 { get; set; }
    }
}
