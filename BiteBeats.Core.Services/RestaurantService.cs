using BiteBeats.Core.Entities.Entity;
using BiteBeats.Core.Entities.ViewModel;
using BiteBeats.Core.Interfaces.Interfaces.Base;
using BiteBeats.Core.Interfaces.Interfaces.Repository;
using BiteBeats.Core.Interfaces.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IUserService _userService;

        public RestaurantService(IRestaurantRepository restaurantRepository, IUserService userService, IUnitOfWorkService unitOfWorkService)
        {
            _restaurantRepository = restaurantRepository;
            _userService = userService;
            _unitOfWorkService = unitOfWorkService;
        }
        public async Task<DbResult> AddRestaurantAsync(UserRestaurantVM userRestaurant)
        {
            try
            {
                _unitOfWorkService.BeginTransaction();

                var user = new UserVM()
                {
                    FirstName = userRestaurant.User.FirstName,
                    LastName = userRestaurant.User.LastName,
                    PhoneNumber = userRestaurant.User.PhoneNumber,
                    Email = userRestaurant.User.Email,
                    Source = userRestaurant.User.Source
                };
                var crateUser = await _userService.RegisteruserAsync(user);
                if (!crateUser.IsDbSuccess)
                {
                    return crateUser;
                }
                var restaurant = new Restuarant()
                {
                    Name = userRestaurant.Restaurant.Name,
                    TagLine = userRestaurant.Restaurant.TagLine,
                    PhoneNumber = userRestaurant.Restaurant.PhoneNumber,
                    Email = userRestaurant.Restaurant.Email,
                    ManagerName = userRestaurant.Restaurant.ManagerName,
                    ManagerPhoneNumber = userRestaurant.Restaurant.ManagerPhoneNumber,
                    PanNumber = userRestaurant.Restaurant.PanNumber,
                    PanImage = userRestaurant.Restaurant.PanImage,
                    GstNumber = userRestaurant.Restaurant.GstNumber,
                    GstImage = userRestaurant.Restaurant.GstImage,
                    AddressLine1 = userRestaurant.Restaurant.AddressLine1,
                    AddressLine2 = userRestaurant.Restaurant.AddressLine2,
                    AddressLine3 = userRestaurant.Restaurant.AddressLine3,
                    PinCode = userRestaurant.Restaurant.PinCode,
                    OwnerId = userRestaurant.Restaurant.OwnerId,
                    City = userRestaurant.Restaurant.City,
                    State = userRestaurant.Restaurant.State,
                    Country = userRestaurant.Restaurant.Country,
                    OpeningHours = userRestaurant.Restaurant.OpeningHours,
                    ClosingHours = userRestaurant.Restaurant.ClosingHours,
                    DeliveryRadius = userRestaurant.Restaurant.DeliveryRadius
                };
                var createResturant = await _restaurantRepository.InsertAsync(restaurant);
                _unitOfWorkService.CommitTransaction();
                return (new DbResult { IsDbSuccess = true, DbMessage = "User Detail Saved Successfully." });
            }
            catch (Exception ex)
            {
                _unitOfWorkService.Rollback();
                return (new DbResult { IsDbSuccess = false, DbMessage = ex.Message });
            }
        }
    }
}
