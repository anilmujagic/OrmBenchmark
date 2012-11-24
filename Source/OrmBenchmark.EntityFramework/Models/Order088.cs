using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order088
    {
        public Order088()
        {
            this.OrderLine088 = new List<OrderLine088>();
        }

        public int Order088ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer088ID { get; set; }
        public string Note { get; set; }
        public virtual Customer088 Customer088 { get; set; }
        public virtual ICollection<OrderLine088> OrderLine088 { get; set; }
    }
}
