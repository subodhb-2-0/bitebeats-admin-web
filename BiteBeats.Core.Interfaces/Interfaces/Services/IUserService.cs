using BiteBeats.Core.Entities.ViewModel;

namespace BiteBeats.Core.Interfaces.Interfaces.Services
{
    public interface IUserService
    {
        Task<DbResult> RegisteruserAsync(UserVM uservm);
    }
}