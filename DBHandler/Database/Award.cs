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
    
    public partial class Award
    {
        public int Id { get; set; }
        public string MemberId { get; set; }
        public string AwardTitle { get; set; }
        public string AwardedBy { get; set; }
        public Nullable<System.DateTime> ReceivedOn { get; set; }
        public string AreaCompititionTitle { get; set; }
        public string Description { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
