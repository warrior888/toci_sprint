using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Toci.Db.Interfaces;

namespace Toci.Sprint.Vote.Dal.Pyrenees
{

    public abstract class DalBase<TModel> : IGenericDbHandle<TModel>
    {
       // protected Dictionary<DalBase, DalBase> DalMap; // = new Dictionary<string, DalBase>();

     // ??


     public IQueryable<TModel> Select(Expression<Func<string, List<TModel>>> @where)
     {
         throw new NotImplementedException();
     }

     public TModel Insert(TModel model)
     {
         throw new NotImplementedException();
     }

     public TModel Update(TModel model)
     {
         throw new NotImplementedException();
     }

     public bool Delete(TModel model)
     {
         throw new NotImplementedException();
     }
    }
}