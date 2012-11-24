using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer016
    {
        public Customer016()
        {
            this.Order016 = new List<Order016>();
        }

        public string Customer016ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order016> Order016 { get; set; }
    }
}
