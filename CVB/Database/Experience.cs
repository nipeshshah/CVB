//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVB.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experience
    {
        public int Id { get; set; }
        public string MemberId { get; set; }
        public string JobTItle { get; set; }
        public string Employer { get; set; }
        public string CIty { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> IsCurrent { get; set; }
        public string Description { get; set; }
    
        public virtual Member Member { get; set; }
    }
}