namespace BiteBeats.Core.Interfaces.Interfaces.Base
{
    public interface IUnitOfWorkService : IDisposable
    {
        void BeginTransaction();
        void CommitTransaction();
        void Rollback();
    }
}
