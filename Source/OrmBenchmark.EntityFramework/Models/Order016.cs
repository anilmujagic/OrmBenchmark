using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order016
    {
        public Order016()
        {
            this.OrderLine016 = new List<OrderLine016>();
        }

        public int Order016ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer016ID { get; set; }
        public string Note { get; set; }
        public virtual Customer016 Customer016 { get; set; }
        public virtual ICollection<OrderLine016> OrderLine016 { get; set; }
    }
}
