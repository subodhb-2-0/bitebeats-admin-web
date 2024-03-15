using System.Linq.Expressions;

namespace BiteBeats.Core.Interfaces.Interfaces.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetManyAsync();
        Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter);
        Task<int> InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(object id);
    }
}
