using BiteBeats.Core.Infrastructure.Persistence;
using BiteBeats.Core.Interfaces.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace BiteBeats.Core.Infrastructure.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BiteBeatsDbContext _dbContext;
        public Repository(BiteBeatsDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            try
            {
                var exists = await _dbContext.Set<TEntity>().AnyAsync(filter);
                if (!exists) return false;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> GetManyAsync()
        {
            try
            {
                return await _dbContext.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            try
            {
                return await _dbContext.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> InsertAsync(TEntity entity)
        {
            try
            {
                if (entity == null) throw new ArgumentNullException("Entity");

                await _dbContext.Set<TEntity>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();

                var ret = 0;
                var key = typeof(TEntity).GetProperties().FirstOrDefault(p =>
                    p.CustomAttributes.Any(attr => attr.AttributeType == typeof(KeyAttribute)));

                if (key != null)
                {
                    var keyType = key.PropertyType;

                    if (keyType == typeof(int))
                    {
                        ret = (int)key.GetValue(entity, null)!;
                    }
                    else if (keyType == typeof(long))
                    {
                        ret = Convert.ToInt32(key.GetValue(entity, null));
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task UpdateAsync(TEntity entityToUpdate)
        {
            try
            {
                if (entityToUpdate == null) throw new ArgumentNullException("Entity");

                _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(object id)
        {
            try
            {
                var entityToDelete = await _dbContext.Set<TEntity>().FindAsync(id);
                if (entityToDelete == null) throw new ArgumentNullException("Entity");
                _dbContext.Set<TEntity>().Remove(entityToDelete);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
