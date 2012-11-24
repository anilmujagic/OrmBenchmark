using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order068
    {
        public Order068()
        {
            this.OrderLine068 = new List<OrderLine068>();
        }

        public int Order068ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer068ID { get; set; }
        public string Note { get; set; }
        public virtual Customer068 Customer068 { get; set; }
        public virtual ICollection<OrderLine068> OrderLine068 { get; set; }
    }
}
