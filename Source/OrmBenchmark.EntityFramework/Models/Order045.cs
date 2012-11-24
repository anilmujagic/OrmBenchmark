using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order045
    {
        public Order045()
        {
            this.OrderLine045 = new List<OrderLine045>();
        }

        public int Order045ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer045ID { get; set; }
        public string Note { get; set; }
        public virtual Customer045 Customer045 { get; set; }
        public virtual ICollection<OrderLine045> OrderLine045 { get; set; }
    }
}
