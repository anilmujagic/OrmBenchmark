using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order067
    {
        public Order067()
        {
            this.OrderLine067 = new List<OrderLine067>();
        }

        public int Order067ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer067ID { get; set; }
        public string Note { get; set; }
        public virtual Customer067 Customer067 { get; set; }
        public virtual ICollection<OrderLine067> OrderLine067 { get; set; }
    }
}
