using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrmBenchmark.PetaPoco
{
    public partial class Order
    {
        public Customer Customer { get; set; }
    }
}
