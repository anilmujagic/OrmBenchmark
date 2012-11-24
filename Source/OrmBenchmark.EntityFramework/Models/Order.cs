using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderLines = new List<OrderLine>();
        }

        public int OrderID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string CustomerID { get; set; }
        public string Note { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
