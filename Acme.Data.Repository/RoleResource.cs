//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acme.Data.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleResource
    {
        public int RoleResourceId { get; set; }
        public int RoleId { get; set; }
        public int ResourceId { get; set; }
    
        public virtual Resource Resource { get; set; }
        public virtual Role Role { get; set; }
    }
}