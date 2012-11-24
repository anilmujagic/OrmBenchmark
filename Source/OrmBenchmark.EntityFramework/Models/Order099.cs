using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order099
    {
        public Order099()
        {
            this.OrderLine099 = new List<OrderLine099>();
        }

        public int Order099ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer099ID { get; set; }
        public string Note { get; set; }
        public virtual Customer099 Customer099 { get; set; }
        public virtual ICollection<OrderLine099> OrderLine099 { get; set; }
    }
}
