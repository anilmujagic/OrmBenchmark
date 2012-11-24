using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order007
    {
        public Order007()
        {
            this.OrderLine007 = new List<OrderLine007>();
        }

        public int Order007ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer007ID { get; set; }
        public string Note { get; set; }
        public virtual Customer007 Customer007 { get; set; }
        public virtual ICollection<OrderLine007> OrderLine007 { get; set; }
    }
}
