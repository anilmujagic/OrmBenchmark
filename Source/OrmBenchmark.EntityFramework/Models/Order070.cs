using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order070
    {
        public Order070()
        {
            this.OrderLine070 = new List<OrderLine070>();
        }

        public int Order070ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer070ID { get; set; }
        public string Note { get; set; }
        public virtual Customer070 Customer070 { get; set; }
        public virtual ICollection<OrderLine070> OrderLine070 { get; set; }
    }
}
