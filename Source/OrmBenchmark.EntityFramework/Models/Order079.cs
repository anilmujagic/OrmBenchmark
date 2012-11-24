using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order079
    {
        public Order079()
        {
            this.OrderLine079 = new List<OrderLine079>();
        }

        public int Order079ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer079ID { get; set; }
        public string Note { get; set; }
        public virtual Customer079 Customer079 { get; set; }
        public virtual ICollection<OrderLine079> OrderLine079 { get; set; }
    }
}
