using BiteBeats.Core.Infrastructure.Persistence;
using BiteBeats.Core.Interfaces.Interfaces.Base;
using Microsoft.EntityFrameworkCore.Storage;

namespace BiteBeats.Core.Infrastructure.Implementations
{
    public class UnitOfWorkRepository : IUnitOfWorkService
    {
        private readonly BiteBeatsDbContext _dbContext;
        private IDbContextTransaction _dbTransaction;

        public UnitOfWorkRepository(BiteBeatsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BeginTransaction()
        {
            _dbTransaction = _dbContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _dbTransaction.Commit();
        }

        public void Rollback()
        {
            _dbTransaction.Rollback();
        }

        public void Dispose()
        {
            _dbTransaction?.Dispose();
        }

    }
}
