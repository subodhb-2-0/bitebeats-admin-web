using BiteBeats.Core.Entities.ViewModel;
using BiteBeats.Core.Entities.Entity;
using BiteBeats.Core.Interfaces.Interfaces.Repository;
using BiteBeats.Core.Interfaces.Interfaces.Services;

namespace BiteBeats.Core.Services
{
    public class UserService : IUserService
    {
        //private readonly IUnitOfWorkRepository _unitOfWorkRepository;
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<DbResult> RegisteruserAsync(UserVM uservm)
        {
            try
            {
                //_unitOfWorkRepository.BeginTransaction();

                var user = new User()
                {
                    FirstName = uservm.FirstName,
                    LastName = uservm.LastName,
                    PhoneNumber = uservm.PhoneNumber,
                    Email = uservm.Email,
                    Source = uservm.Source,
                    IdentityId = "test"
                };
                var User = await _userRepository.InsertAsync(user);


                return (new DbResult { IsDbSuccess = true, DbMessage = "User Detail Saved Successfully." });
            }
            catch (Exception ex)
            {
                //_unitOfWorkRepository.Rollback();
                return (new DbResult { IsDbSuccess = false, DbMessage = ex.Message });
            }
        }
    }
}
