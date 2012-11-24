using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order083
    {
        public Order083()
        {
            this.OrderLine083 = new List<OrderLine083>();
        }

        public int Order083ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer083ID { get; set; }
        public string Note { get; set; }
        public virtual Customer083 Customer083 { get; set; }
        public virtual ICollection<OrderLine083> OrderLine083 { get; set; }
    }
}
