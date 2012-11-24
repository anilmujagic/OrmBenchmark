using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order074
    {
        public Order074()
        {
            this.OrderLine074 = new List<OrderLine074>();
        }

        public int Order074ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer074ID { get; set; }
        public string Note { get; set; }
        public virtual Customer074 Customer074 { get; set; }
        public virtual ICollection<OrderLine074> OrderLine074 { get; set; }
    }
}
