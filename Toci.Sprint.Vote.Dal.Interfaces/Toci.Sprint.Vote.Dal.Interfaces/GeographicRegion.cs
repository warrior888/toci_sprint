//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Sprint.Vote.Dal.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class GeographicRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GeographicRegion()
        {
            this.GeographicRegions1 = new HashSet<GeographicRegion>();
            this.VoteUsers = new HashSet<VoteUser>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdGeographicRegions { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeographicRegion> GeographicRegions1 { get; set; }
        public virtual GeographicRegion GeographicRegion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoteUser> VoteUsers { get; set; }
    }
}
