using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order093
    {
        public Order093()
        {
            this.OrderLine093 = new List<OrderLine093>();
        }

        public int Order093ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer093ID { get; set; }
        public string Note { get; set; }
        public virtual Customer093 Customer093 { get; set; }
        public virtual ICollection<OrderLine093> OrderLine093 { get; set; }
    }
}
