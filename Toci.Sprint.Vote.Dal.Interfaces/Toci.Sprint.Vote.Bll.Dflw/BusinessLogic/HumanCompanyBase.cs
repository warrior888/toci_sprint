using System.Collections.Generic;
using Toci.Sprint.Vote.Bll.Dflw.Interfaces;
using Toci.Sprint.Vote.Bll.Dflw.Interfaces.BusinessLogic;

namespace Toci.Sprint.Vote.Bll.Dflw.BusinessLogic
{
    public class HumanCompanyBase : IHumanCompany
    {
        public virtual Dictionary<IHuman, Dictionary<IHuman, IHuman>> GetCompanyCollocations(IHuman human)
        {
            return GetCollocations(human);
        }

        protected virtual Dictionary<IHuman, Dictionary<IHuman, IHuman>> GetCollocations(IHuman human)
        {
            // dal db get for id
            ///human.Id
            //human.HumanInfo.Occupation 
            Dictionary<IHuman, Dictionary<IHuman, IHuman>>
                result = new Dictionary<IHuman, Dictionary<IHuman, IHuman>>();

            // ?dal get

            return result;
        }
    }
}