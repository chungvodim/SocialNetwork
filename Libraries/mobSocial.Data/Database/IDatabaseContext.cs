using System.Data.Entity;
using mobSocial.Core.Data;
using System.Data.Entity.Infrastructure;

namespace mobSocial.Data.Database
{
    public interface IDatabaseContext
    {
        IDbSet<T> Set<T>() where T : BaseEntity;

        void ExecuteSql(TransactionalBehavior? transactionalBehavior, string sqlQuery, params object[] parameters);

        int SaveChanges();

        bool DatabaseExists();

        System.Data.Entity.Database Database { get; }

        DbEntityEntry Entry(object entity);

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}