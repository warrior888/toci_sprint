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
    
    public partial class FriendVote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FriendVote()
        {
            this.FriendVotes1 = new HashSet<FriendVote>();
            this.FriendVotes11 = new HashSet<FriendVote>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdFriendsVotes { get; set; }
        public Nullable<int> IdVoteUsers { get; set; }
        public Nullable<int> IdVoteUsersFriend { get; set; }
        public Nullable<int> IdCandidates { get; set; }
        public Nullable<bool> AllowedToShow { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FriendVote> FriendVotes1 { get; set; }
        public virtual FriendVote FriendVote1 { get; set; }
        public virtual Candidate Candidate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FriendVote> FriendVotes11 { get; set; }
        public virtual FriendVote FriendVote11 { get; set; }
        public virtual VoteUser VoteUser { get; set; }
    }
}
