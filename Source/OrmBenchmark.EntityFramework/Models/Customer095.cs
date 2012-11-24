using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer095
    {
        public Customer095()
        {
            this.Order095 = new List<Order095>();
        }

        public string Customer095ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order095> Order095 { get; set; }
    }
}
