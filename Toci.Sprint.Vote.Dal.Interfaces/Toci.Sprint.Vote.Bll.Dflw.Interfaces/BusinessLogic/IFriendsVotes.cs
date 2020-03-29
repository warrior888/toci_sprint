using System.Collections.Generic;
using Toci.Sprint.Vote.Dal.Interfaces;

namespace Toci.Sprint.Vote.Bll.Dflw.Interfaces
{
    public interface IFriendsVotes : IHuman
    {
        Dictionary<VoteUser, Dictionary<VoteUser, FriendVote>> GetFriendsVotes(FriendVote human, int friendId);
    }
}