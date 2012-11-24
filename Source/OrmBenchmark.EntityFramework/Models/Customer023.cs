using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer023
    {
        public Customer023()
        {
            this.Order023 = new List<Order023>();
        }

        public string Customer023ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order023> Order023 { get; set; }
    }
}
