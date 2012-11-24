using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order055
    {
        public Order055()
        {
            this.OrderLine055 = new List<OrderLine055>();
        }

        public int Order055ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer055ID { get; set; }
        public string Note { get; set; }
        public virtual Customer055 Customer055 { get; set; }
        public virtual ICollection<OrderLine055> OrderLine055 { get; set; }
    }
}
