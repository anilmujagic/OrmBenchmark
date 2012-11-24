using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order039
    {
        public Order039()
        {
            this.OrderLine039 = new List<OrderLine039>();
        }

        public int Order039ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer039ID { get; set; }
        public string Note { get; set; }
        public virtual Customer039 Customer039 { get; set; }
        public virtual ICollection<OrderLine039> OrderLine039 { get; set; }
    }
}
