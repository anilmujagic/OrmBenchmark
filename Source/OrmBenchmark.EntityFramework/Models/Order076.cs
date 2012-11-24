using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order076
    {
        public Order076()
        {
            this.OrderLine076 = new List<OrderLine076>();
        }

        public int Order076ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer076ID { get; set; }
        public string Note { get; set; }
        public virtual Customer076 Customer076 { get; set; }
        public virtual ICollection<OrderLine076> OrderLine076 { get; set; }
    }
}
