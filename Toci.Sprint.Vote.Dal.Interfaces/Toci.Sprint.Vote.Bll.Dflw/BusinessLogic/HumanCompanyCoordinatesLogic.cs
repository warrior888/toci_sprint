using System.Collections.Generic;
using Toci.Sprint.Vote.Bll.Dflw.Interfaces;

namespace Toci.Sprint.Vote.Bll.Dflw.BusinessLogic
{
    public class HumanCompanyCoordinatesLogic : HumanCompanyBase
    {
        protected override Dictionary<IHuman, Dictionary<IHuman, IHuman>> GetCollocations(IHuman human)
        {
            // wspol coordinates ?
         //   human.HumanInfo.Longitude
         return null;
        }
    }
}