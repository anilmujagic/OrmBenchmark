using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order087
    {
        public Order087()
        {
            this.OrderLine087 = new List<OrderLine087>();
        }

        public int Order087ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer087ID { get; set; }
        public string Note { get; set; }
        public virtual Customer087 Customer087 { get; set; }
        public virtual ICollection<OrderLine087> OrderLine087 { get; set; }
    }
}
