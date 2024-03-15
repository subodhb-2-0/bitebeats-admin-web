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
    public class RestaurantRepository : Repository<Restuarant>, IRestaurantRepository
    {
        public RestaurantRepository(BiteBeatsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
