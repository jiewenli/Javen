using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Javen.EntityFramework.Repositories
{
    public abstract class JavenRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JavenDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected JavenRepositoryBase(IDbContextProvider<JavenDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class JavenRepositoryBase<TEntity> : JavenRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JavenRepositoryBase(IDbContextProvider<JavenDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
