using BiteBeats.Core.Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BiteBeats.Web.Controllers
{
    public class MenuController : Controller
    {
        private IEnumerable<MenuVM> menuItemsForAllRestaurants = new List<MenuVM>
        {
            // Restaurant 1
            new MenuVM { Id = new Guid("90c5d9e8-05c1-4f63-a3b4-476c5ac9140d"), Name = "Breakfast", Description = "Start your day right with our delicious breakfast options.", Image = "breakfast.jpg", RestaurantId = new Guid("4d3cb3a6-50bb-4a4b-bd1a-690b35c1cf69") },
            new MenuVM { Id = new Guid("dbb17462-fc1e-45ec-b9ed-5a67e74329f5"), Name = "Lunch", Description = "Enjoy a satisfying lunch with our flavorful dishes.", Image = "lunch.jpg", RestaurantId = new Guid("4d3cb3a6-50bb-4a4b-bd1a-690b35c1cf69") },
            new MenuVM { Id = new Guid("36a5f336-2444-4036-b9d1-442d5c1a6888"), Name = "Dinner", Description = "Indulge in an elegant dinner with our exquisite offerings.", Image = "dinner.jpg", RestaurantId = new Guid("4d3cb3a6-50bb-4a4b-bd1a-690b35c1cf69") },

            // Restaurant 2
            new MenuVM { Id = new Guid("ad0a7a44-c53e-4c84-bc8b-3dfb6d1e1f6d"), Name = "Breakfast", Description = "Start your day right with our delicious breakfast options.", Image = "breakfast.jpg", RestaurantId = new Guid("8e8cf46c-285b-4e82-9ac2-1d30c5b74111") },
            new MenuVM { Id = new Guid("6e88b4d2-6d52-4609-b3cb-3d8a87a011ab"), Name = "Lunch", Description = "Enjoy a satisfying lunch with our flavorful dishes.", Image = "lunch.jpg", RestaurantId = new Guid("8e8cf46c-285b-4e82-9ac2-1d30c5b74111") },
            new MenuVM { Id = new Guid("5d695724-5bb3-457e-bc57-cd89b3dd22ad"), Name = "Dinner", Description = "Indulge in an elegant dinner with our exquisite offerings.", Image = "dinner.jpg", RestaurantId = new Guid("8e8cf46c-285b-4e82-9ac2-1d30c5b74111") },

            // Restaurant 3
            new MenuVM { Id = new Guid("3a79e2c8-40f7-4295-a17d-4956f08b1d6c"), Name = "Breakfast", Description = "Start your day right with our delicious breakfast options.", Image = "breakfast.jpg", RestaurantId = new Guid("aa258c4e-36e6-41af-88d7-d3b02c0f2c5e") },
            new MenuVM { Id = new Guid("3bdc0590-2e2e-4547-9e1b-d49d9904c4e9"), Name = "Lunch", Description = "Enjoy a satisfying lunch with our flavorful dishes.", Image = "lunch.jpg", RestaurantId = new Guid("aa258c4e-36e6-41af-88d7-d3b02c0f2c5e") },
            new MenuVM { Id = new Guid("6f4b124b-8eac-4c4d-b8f8-02debbf19d54"), Name = "Dinner", Description = "Indulge in an elegant dinner with our exquisite offerings.", Image = "dinner.jpg", RestaurantId = new Guid("aa258c4e-36e6-41af-88d7-d3b02c0f2c5e") },

            // Restaurant 4
            new MenuVM { Id = new Guid("9df61c15-0545-499b-92c8-4d67cf74750d"), Name = "Breakfast", Description = "Start your day right with our delicious breakfast options.", Image = "breakfast.jpg", RestaurantId = new Guid("e67d60df-199b-4c6c-a04f-d92d2b9d3f60") },
            new MenuVM { Id = new Guid("7c3af6ef-fb27-4f23-a916-b2cc69e4b7fd"), Name = "Lunch", Description = "Enjoy a satisfying lunch with our flavorful dishes.", Image = "lunch.jpg", RestaurantId = new Guid("e67d60df-199b-4c6c-a04f-d92d2b9d3f60") },
            new MenuVM { Id = new Guid("b40531f2-232b-4cd4-aa25-bec0f86543cf"), Name = "Dinner", Description = "Indulge in an elegant dinner with our exquisite offerings.", Image = "dinner.jpg", RestaurantId = new Guid("e67d60df-199b-4c6c-a04f-d92d2b9d3f60") },

            // Restaurant 5
            new MenuVM { Id = new Guid("13d9c6c3-2d8d-4a51-8b5a-e42426abfb95"), Name = "Breakfast", Description = "Start your day right with our delicious breakfast options.", Image = "breakfast.jpg", RestaurantId = new Guid("83a91abf-d4b1-4f64-b3c3-f89995f3ed27") },
            new MenuVM { Id = new Guid("9f442f48-1c3d-4f6d-b429-b8d79a52f95b"), Name = "Lunch", Description = "Enjoy a satisfying lunch with our flavorful dishes.", Image = "lunch.jpg", RestaurantId = new Guid("83a91abf-d4b1-4f64-b3c3-f89995f3ed27") },
            new MenuVM { Id = new Guid("c1ff155b-2747-484f-93a0-0cfe19b44430"), Name = "Dinner", Description = "Indulge in an elegant dinner with our exquisite offerings.", Image = "dinner.jpg", RestaurantId = new Guid("83a91abf-d4b1-4f64-b3c3-f89995f3ed27") }
        };
        public IActionResult Index(Guid restaurantId)
        {
            var menu = menuItemsForAllRestaurants.Where(x => x.RestaurantId == restaurantId);
            return View(menu);
        }
        public IActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuCreateVM createVM)
        {

            //write code to create menu

            return Content("Ok");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, MenuEditVM editVM)
        {
            // write code to edit menu

            return Content("Ok");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            //write code to delete menu

            return Content("Ok");
        }
    }
}
