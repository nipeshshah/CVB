//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBHandler.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plan
    {
        public int PlanId { get; set; }
        public string MemberId { get; set; }
        public string GoogleId { get; set; }
        public string RegisteredEmail { get; set; }
        public Nullable<int> SubscribedPlan { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string Comments { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
