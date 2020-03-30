using System.Collections.Generic;
using System.Linq;
using Toci.Sprint.Vote.Bll.Dflw.Interfaces;
using Toci.Sprint.Vote.Dal.Interfaces;
using Toci.Sprint.Vote.Dal.Pyrenees;
using VoteUser = Toci.Sprint.Vote.Dal.Interfaces.VoteUser;

namespace Toci.Sprint.Vote.Bll.Dflw
{
    public abstract class FriendsVotesBase : IFriendsVotes 
    {
        public IHumanInfo HumanInfo { get; set; }
        public int Id { get; set; }

        protected DalBase<FriendVote> Dal = new DalBase<FriendVote>();

        public virtual Dictionary<VoteUser, Dictionary<VoteUser, FriendVote>> GetFriendsVotes(FriendVote human, int friendId)
        {
            Dictionary<VoteUser, Dictionary<VoteUser, FriendVote>> result = new Dictionary<VoteUser, Dictionary<VoteUser, FriendVote>>();
            //bll
            //GetFriendsVotesCollection

            // ??
            return result;
        }

        protected virtual IQueryable<FriendVote> GetFriendsVotesCollection(FriendVote human, int friendId)
        {
            Dictionary<VoteUser, Dictionary<VoteUser, FriendVote>> result = new Dictionary<VoteUser, Dictionary<VoteUser, FriendVote>>();
            //dal
            return Dal.Select((model, id) => (human.IdVoteUsers == friendId));
        }
        
        
    }
}