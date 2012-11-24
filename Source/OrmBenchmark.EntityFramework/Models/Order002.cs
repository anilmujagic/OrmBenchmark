using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order002
    {
        public Order002()
        {
            this.OrderLine002 = new List<OrderLine002>();
        }

        public int Order002ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer002ID { get; set; }
        public string Note { get; set; }
        public virtual Customer002 Customer002 { get; set; }
        public virtual ICollection<OrderLine002> OrderLine002 { get; set; }
    }
}
