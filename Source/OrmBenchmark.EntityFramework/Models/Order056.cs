using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order056
    {
        public Order056()
        {
            this.OrderLine056 = new List<OrderLine056>();
        }

        public int Order056ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer056ID { get; set; }
        public string Note { get; set; }
        public virtual Customer056 Customer056 { get; set; }
        public virtual ICollection<OrderLine056> OrderLine056 { get; set; }
    }
}
