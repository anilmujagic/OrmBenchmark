using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order047
    {
        public Order047()
        {
            this.OrderLine047 = new List<OrderLine047>();
        }

        public int Order047ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer047ID { get; set; }
        public string Note { get; set; }
        public virtual Customer047 Customer047 { get; set; }
        public virtual ICollection<OrderLine047> OrderLine047 { get; set; }
    }
}
