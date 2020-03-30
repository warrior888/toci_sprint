using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Toci.Db.Interfaces;

namespace Toci.Sprint.Vote.Dal.Pyrenees
{
    
    public class DalBase<TModel> : IGenericDbHandle<TModel> where TModel : class
    {
        protected voteEntities DbContext = new voteEntities();

         public virtual IQueryable<TModel> Select(Expression<Func<TModel, int, bool>> @where)
         {
             return DbContext.Set<TModel>().Where(@where);
         }

         public virtual TModel Insert(TModel model)
         {
             TModel inserted = DbContext.Set<TModel>().Add(model);
             DbContext.SaveChanges();

             return inserted;
         }

         public virtual TModel Update(TModel model)
         {
             TModel updated = DbContext.Set<TModel>().Attach(model);
             DbContext.SaveChanges();

             return updated;
         }

         public virtual bool Delete(TModel model)
         {
             TModel deleted = DbContext.Set<TModel>().Remove(model);
             DbContext.SaveChanges();

             return deleted == null;
         }
    }
}