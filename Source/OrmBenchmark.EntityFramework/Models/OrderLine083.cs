//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrmBenchmark.EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLine083
    {
        public int OrderLine083ID { get; set; }
        public int Order083ID { get; set; }
        public string Item083ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual Item083 Item083 { get; set; }
        public virtual Order083 Order083 { get; set; }
    }
}
