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
    
    public partial class OrderLine063
    {
        public int OrderLine063ID { get; set; }
        public int Order063ID { get; set; }
        public string Item063ID { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual Item063 Item063 { get; set; }
        public virtual Order063 Order063 { get; set; }
    }
}
