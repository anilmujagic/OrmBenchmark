using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order075
    {
        public Order075()
        {
            this.OrderLine075 = new List<OrderLine075>();
        }

        public int Order075ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer075ID { get; set; }
        public string Note { get; set; }
        public virtual Customer075 Customer075 { get; set; }
        public virtual ICollection<OrderLine075> OrderLine075 { get; set; }
    }
}
