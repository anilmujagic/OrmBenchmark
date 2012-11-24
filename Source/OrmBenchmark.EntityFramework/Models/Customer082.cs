using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer082
    {
        public Customer082()
        {
            this.Order082 = new List<Order082>();
        }

        public string Customer082ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order082> Order082 { get; set; }
    }
}
