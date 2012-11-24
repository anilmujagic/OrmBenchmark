using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order040
    {
        public Order040()
        {
            this.OrderLine040 = new List<OrderLine040>();
        }

        public int Order040ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer040ID { get; set; }
        public string Note { get; set; }
        public virtual Customer040 Customer040 { get; set; }
        public virtual ICollection<OrderLine040> OrderLine040 { get; set; }
    }
}
