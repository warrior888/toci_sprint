using System.Collections.Generic;
using Toci.Sprint.Vote.Bll.Dflw.Interfaces;
using Toci.Sprint.Vote.Dal.Interfaces;

namespace Toci.Sprint.Vote.Bll.Dflw
{
    public abstract class FriendsVotesBase : IFriendsVotes
    {
        public IHumanInfo HumanInfo { get; set; }
        public int Id { get; set; }

        public Dictionary<IVoteHuman, Dictionary<IVoteHuman, IFriendsVotes>> GetFriendsVotes(IVoteHuman human)
        {
            Dictionary < IVoteHuman, Dictionary < IVoteHuman, IFriendsVotes >> result = new Dictionary<IVoteHuman,Dictionary<IVoteHuman,IFriendsVotes>>();
            return result;
        }

        protected virtual Dictionary<IVoteHuman, Dictionary<IVoteHuman, IFriendsVotes>> GetFriendsVotesCollection(int humanId)
        {
            Dictionary<IVoteHuman, Dictionary<IVoteHuman, IFriendsVotes>> result = new Dictionary<IVoteHuman, Dictionary<IVoteHuman, IFriendsVotes>>();
            return result;
        }
        
        
    }
}