using System.Collections.Generic;

namespace Toci.Sprint.Vote.Bll.Dflw.Interfaces.BusinessLogic
{
    public interface IHumanCompany
    {
        Dictionary<IHuman, Dictionary<IHuman, IHuman>> GetCompanyCollocations(IHuman human);

    }
}