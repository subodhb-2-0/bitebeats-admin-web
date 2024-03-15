using BiteBeats.Core.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Interfaces.Interfaces.Services
{
    public interface IRestaurantService
    {
        Task<DbResult> AddRestaurantAsync(UserRestaurantVM userRestaurant);
    }
}
