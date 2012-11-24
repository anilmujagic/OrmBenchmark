using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order050
    {
        public Order050()
        {
            this.OrderLine050 = new List<OrderLine050>();
        }

        public int Order050ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer050ID { get; set; }
        public string Note { get; set; }
        public virtual Customer050 Customer050 { get; set; }
        public virtual ICollection<OrderLine050> OrderLine050 { get; set; }
    }
}
