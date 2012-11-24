using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order008
    {
        public Order008()
        {
            this.OrderLine008 = new List<OrderLine008>();
        }

        public int Order008ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer008ID { get; set; }
        public string Note { get; set; }
        public virtual Customer008 Customer008 { get; set; }
        public virtual ICollection<OrderLine008> OrderLine008 { get; set; }
    }
}
