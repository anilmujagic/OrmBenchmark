using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order082
    {
        public Order082()
        {
            this.OrderLine082 = new List<OrderLine082>();
        }

        public int Order082ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer082ID { get; set; }
        public string Note { get; set; }
        public virtual Customer082 Customer082 { get; set; }
        public virtual ICollection<OrderLine082> OrderLine082 { get; set; }
    }
}
