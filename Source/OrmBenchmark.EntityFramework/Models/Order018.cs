using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order018
    {
        public Order018()
        {
            this.OrderLine018 = new List<OrderLine018>();
        }

        public int Order018ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer018ID { get; set; }
        public string Note { get; set; }
        public virtual Customer018 Customer018 { get; set; }
        public virtual ICollection<OrderLine018> OrderLine018 { get; set; }
    }
}
