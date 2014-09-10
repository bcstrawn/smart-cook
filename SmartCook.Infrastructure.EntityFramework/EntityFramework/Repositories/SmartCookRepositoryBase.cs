using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace SmartCook.EntityFramework.Repositories
{
    public abstract class SmartCookRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SmartCookDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class SmartCookRepositoryBase<TEntity> : SmartCookRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
