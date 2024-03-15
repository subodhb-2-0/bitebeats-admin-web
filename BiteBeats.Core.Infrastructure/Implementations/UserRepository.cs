using BiteBeats.Core.Entities.Entity;
using BiteBeats.Core.Infrastructure.Persistence;
using BiteBeats.Core.Interfaces.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Infrastructure.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BiteBeatsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
