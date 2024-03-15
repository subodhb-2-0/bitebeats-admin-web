using BiteBeats.Core.Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BiteBeats.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private IEnumerable<RestaurantVM> restaurantsInCity = new List<RestaurantVM>
        {
            new RestaurantVM { Id = new Guid("4d3cb3a6-50bb-4a4b-bd1a-690b35c1cf69"), Name = "Tasty Bites", PhoneNumber = "123-456-7890", ManagerName = "John Smith", ManagerPhoneNumber = "987-654-3210", OwnerName = "Alice Johnson", City = "New York" },
            new RestaurantVM { Id = new Guid("8e8cf46c-285b-4e82-9ac2-1d30c5b74111"), Name = "Sizzle Grill", PhoneNumber = "456-789-0123", ManagerName = "Emily Davis", ManagerPhoneNumber = "654-321-0987", OwnerName = "Bob Williams", City = "New York" },
            new RestaurantVM { Id = new Guid("aa258c4e-36e6-41af-88d7-d3b02c0f2c5e"), Name = "Spice Palace", PhoneNumber = "789-012-3456", ManagerName = "Michael Brown", ManagerPhoneNumber = "321-098-7654", OwnerName = "Carol Jones", City = "New York" },
            new RestaurantVM { Id = new Guid("e67d60df-199b-4c6c-a04f-d92d2b9d3f60"), Name = "Burger Junction", PhoneNumber = "123-456-7890", ManagerName = "Chris Thompson", ManagerPhoneNumber = "987-654-3210", OwnerName = "David Clark", City = "Los Angeles" },
            new RestaurantVM { Id = new Guid("83a91abf-d4b1-4f64-b3c3-f89995f3ed27"), Name = "Pizza Haven", PhoneNumber = "456-789-0123", ManagerName = "Sarah White", ManagerPhoneNumber = "654-321-0987", OwnerName = "Emma Lee", City = "Los Angeles" },
            new RestaurantVM { Id = new Guid("e9a48b1f-dad9-4cd5-8125-89db5c5d8bc1"), Name = "Mexican Delight", PhoneNumber = "789-012-3456", ManagerName = "James Wilson", ManagerPhoneNumber = "321-098-7654", OwnerName = "Frank Brown", City = "Los Angeles" },
            new RestaurantVM { Id = new Guid("5411e42b-dfb1-4e7a-b3f0-b74b76f3b1c9"), Name = "Sushi Heaven", PhoneNumber = "123-456-7890", ManagerName = "Laura Taylor", ManagerPhoneNumber = "987-654-3210", OwnerName = "Grace Martinez", City = "Chicago" },
            new RestaurantVM { Id = new Guid("d3f65b48-7f0c-4d8b-9192-151a8e0fb24d"), Name = "Pasta Paradise", PhoneNumber = "456-789-0123", ManagerName = "Daniel Harris", ManagerPhoneNumber = "654-321-0987", OwnerName = "Hannah Young", City = "Chicago" },
            new RestaurantVM { Id = new Guid("7ae4b4b2-c98c-4f1c-a365-fbb20f97f4f2"), Name = "BBQ Barn", PhoneNumber = "789-012-3456", ManagerName = "Olivia Rodriguez", ManagerPhoneNumber = "321-098-7654", OwnerName = "Ian Davis", City = "Chicago" },
            new RestaurantVM { Id = new Guid("8b7b7c87-78a4-4971-8dcb-1c40c1f9db98"), Name = "Veggie Garden", PhoneNumber = "123-456-7890", ManagerName = "Jacob Moore", ManagerPhoneNumber = "987-654-3210", OwnerName = "Katie Johnson", City = "Chicago" }
        };
        public IActionResult Index()
        {
            return View(restaurantsInCity);
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
