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
    
    public partial class PublicProfile
    {
        public int Id { get; set; }
        public string MemberId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    
        public virtual Member Member { get; set; }
    }
}