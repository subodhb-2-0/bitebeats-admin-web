using BiteBeats.Core.Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BiteBeats.Web.Controllers
{
    public class SubSectionController : Controller
    {
        private IEnumerable<SubSectionVM> subSectionsForAllMenus = new List<SubSectionVM>
        {
            // Menu 1: Breakfast at Restaurant 1
            new SubSectionVM { Id = new Guid("a3702ae4-fa2f-4d48-a1d0-2cda1b572b13"), Name = "Veg", Description = "Vegetarian breakfast options.", MenuId = new Guid("90c5d9e8-05c1-4f63-a3b4-476c5ac9140d"), Image = "veg_breakfast.jpg" },
            new SubSectionVM { Id = new Guid("2d3bc4d2-98bb-4b82-8231-24b1dc2f1b55"), Name = "Non-Veg", Description = "Non-vegetarian breakfast options.", MenuId = new Guid("90c5d9e8-05c1-4f63-a3b4-476c5ac9140d"), Image = "non_veg_breakfast.jpg" },

            // Menu 2: Lunch at Restaurant 1
            new SubSectionVM { Id = new Guid("655a8dd8-7832-49a3-830f-3f9727cbaf23"), Name = "Veg", Description = "Vegetarian lunch options.", MenuId = new Guid("dbb17462-fc1e-45ec-b9ed-5a67e74329f5"), Image = "veg_lunch.jpg" },
            new SubSectionVM { Id = new Guid("bc4e61ed-937d-4f5b-b62e-95cb62893d1a"), Name = "Non-Veg", Description = "Non-vegetarian lunch options.", MenuId = new Guid("dbb17462-fc1e-45ec-b9ed-5a67e74329f5"), Image = "non_veg_lunch.jpg" },

            // Menu 3: Dinner at Restaurant 1
            new SubSectionVM { Id = new Guid("deea9b2b-fb9b-4701-8a65-c646b8f27f9b"), Name = "Hot", Description = "Hot dinner options.", MenuId = new Guid("36a5f336-2444-4036-b9d1-442d5c1a6888"), Image = "hot_dinner.jpg" },
            new SubSectionVM { Id = new Guid("22af4225-3773-4351-bba7-3e8e1ac73911"), Name = "Cold", Description = "Cold dinner options.", MenuId = new Guid("36a5f336-2444-4036-b9d1-442d5c1a6888"), Image = "cold_dinner.jpg" },

            // Menu 4: Breakfast at Restaurant 2
            new SubSectionVM { Id = new Guid("142ee856-cb1b-4815-84bb-d7f5ff83e9a5"), Name = "Veg", Description = "Vegetarian breakfast options.", MenuId = new Guid("ad0a7a44-c53e-4c84-bc8b-3dfb6d1e1f6d"), Image = "veg_breakfast.jpg" },
            new SubSectionVM { Id = new Guid("4c470160-ff7d-4b2c-bd81-74d4952856f9"), Name = "Non-Veg", Description = "Non-vegetarian breakfast options.", MenuId = new Guid("ad0a7a44-c53e-4c84-bc8b-3dfb6d1e1f6d"), Image = "non_veg_breakfast.jpg" },

            // Menu 5: Lunch at Restaurant 2
            new SubSectionVM { Id = new Guid("f637dc65-0a93-47ad-bfce-4f1ad59d2e71"), Name = "Hot", Description = "Hot lunch options.", MenuId = new Guid("6e88b4d2-6d52-4609-b3cb-3d8a87a011ab"), Image = "hot_lunch.jpg" },
            new SubSectionVM { Id = new Guid("cd9cb52a-625d-4b80-ae12-92bbef4c4c35"), Name = "Cold", Description = "Cold lunch options.", MenuId = new Guid("6e88b4d2-6d52-4609-b3cb-3d8a87a011ab"), Image = "cold_lunch.jpg" },

            // Menu 6: Dinner at Restaurant 2
            new SubSectionVM { Id = new Guid("f012bd16-49e8-4de1-9fa1-accfc3d9a1e7"), Name = "Veg", Description = "Vegetarian dinner options.", MenuId = new Guid("5d695724-5bb3-457e-bc57-cd89b3dd22ad"), Image = "veg_dinner.jpg" },
            new SubSectionVM { Id = new Guid("7cc8c9fc-9433-43df-a6b1-30351f073010"), Name = "Non-Veg", Description = "Non-vegetarian dinner options.", MenuId = new Guid("5d695724-5bb3-457e-bc57-cd89b3dd22ad"), Image = "non_veg_dinner.jpg" },

            // Menu 7: Breakfast at Restaurant 3
            new SubSectionVM { Id = new Guid("31d92239-6318-4e5d-b9e0-4e41f2577aaf"), Name = "Veg", Description = "Vegetarian breakfast options.", MenuId = new Guid("3a79e2c8-40f7-4295-a17d-4956f08b1d6c"), Image = "veg_breakfast.jpg" },
            new SubSectionVM { Id = new Guid("d46d9a62-46de-4d44-9cf0-1bb590c22891"), Name = "Non-Veg", Description = "Non-vegetarian breakfast options.", MenuId = new Guid("3a79e2c8-40f7-4295-a17d-4956f08b1d6c"), Image = "non_veg_breakfast.jpg" },

            // Menu 8: Lunch at Restaurant 3
            new SubSectionVM { Id = new Guid("8d9616b4-df40-40f1-bb8f-18e5c7b8de4e"), Name = "Veg", Description = "Vegetarian lunch options.", MenuId =  new Guid("3bdc0590-2e2e-4547-9e1b-d49d9904c4e9"), Image = "veg_lunch.jpg" },
            new SubSectionVM { Id = new Guid("c5dd99f8-4720-4d22-a88e-df429b1c3e3e"), Name = "Non-Veg", Description = "Non-vegetarian lunch options.", MenuId = new Guid("3bdc0590-2e2e-4547-9e1b-d49d9904c4e9"), Image = "non_veg_lunch.jpg" },

            // Menu 9: Dinner at Restaurant 3
            new SubSectionVM { Id = new Guid("c34ab7d0-4ab5-4ba4-b57d-29a2727f6e0d"), Name = "Hot", Description = "Hot dinner options.", MenuId = new Guid("6f4b124b-8eac-4c4d-b8f8-02debbf19d54"), Image = "hot_dinner.jpg" },
            new SubSectionVM { Id = new Guid("55d5939e-5b02-466d-92b1-dc9eef82fbc9"), Name = "Cold", Description = "Cold dinner options.", MenuId = new Guid("6f4b124b-8eac-4c4d-b8f8-02debbf19d54"), Image = "cold_dinner.jpg" },

            // Menu 10: Breakfast at Restaurant 4
            new SubSectionVM { Id = new Guid("d7ae31d7-0572-4dd2-92b1-9f8335878586"), Name = "Veg", Description = "Vegetarian breakfast options.", MenuId = new Guid("9df61c15-0545-499b-92c8-4d67cf74750d"), Image = "veg_breakfast.jpg" },
            new SubSectionVM { Id = new Guid("4b2e0a67-e268-4637-8f13-195e84cc264d"), Name = "Non-Veg", Description = "Non-vegetarian breakfast options.", MenuId = new Guid("9df61c15-0545-499b-92c8-4d67cf74750d"), Image = "non_veg_breakfast.jpg" },

            // Menu 11: Lunch at Restaurant 4
            new SubSectionVM { Id = new Guid("1bb58f19-17d9-429e-b62f-7a94b4351fa1"), Name = "Hot", Description = "Hot lunch options.", MenuId = new Guid("7c3af6ef-fb27-4f23-a916-b2cc69e4b7fd"), Image = "hot_lunch.jpg" },
            new SubSectionVM { Id = new Guid("d422ca64-6ad0-4d6b-b696-787aceb7a328"), Name = "Cold", Description = "Cold lunch options.", MenuId = new Guid("7c3af6ef-fb27-4f23-a916-b2cc69e4b7fd"), Image = "cold_lunch.jpg" },

            // Menu 12: Dinner at Restaurant 4
            new SubSectionVM { Id = new Guid("c65b83ee-4ff1-48ae-8a82-d7de83979e4d"), Name = "Veg", Description = "Vegetarian dinner options.", MenuId = new Guid("b40531f2-232b-4cd4-aa25-bec0f86543cf"), Image = "veg_dinner.jpg" },
            new SubSectionVM { Id = new Guid("bc8e6466-03a7-49b4-b5ff-42e0b7a0f5c4"), Name = "Non-Veg", Description = "Non-vegetarian dinner options.", MenuId = new Guid("b40531f2-232b-4cd4-aa25-bec0f86543cf"), Image = "non_veg_dinner.jpg" },

            // Menu 13: Breakfast at Restaurant 5
            new SubSectionVM { Id = new Guid("885f7852-d6f7-4a2a-bb07-c1c7114ec74a"), Name = "Veg", Description = "Vegetarian breakfast options.", MenuId = new Guid("13d9c6c3-2d8d-4a51-8b5a-e42426abfb95"), Image = "veg_breakfast.jpg" },
            new SubSectionVM { Id = new Guid("d83a9083-f0e0-4c45-b70a-b29b31dc37dc"), Name = "Non-Veg", Description = "Non-vegetarian breakfast options.", MenuId = new Guid("13d9c6c3-2d8d-4a51-8b5a-e42426abfb95"), Image = "non_veg_breakfast.jpg" },

            // Menu 14: Lunch at Restaurant 5
            new SubSectionVM { Id = new Guid("b3df6cd5-1fc7-46ac-816d-c3c7c20f2289"), Name = "Hot", Description = "Hot lunch options.", MenuId = new Guid("9f442f48-1c3d-4f6d-b429-b8d79a52f95b"), Image = "hot_lunch.jpg" },
            new SubSectionVM { Id = new Guid("1a8cc700-2a7b-4d8c-988f-b2f588c5a7cb"), Name = "Cold", Description = "Cold lunch options.", MenuId = new Guid("9f442f48-1c3d-4f6d-b429-b8d79a52f95b"), Image = "cold_lunch.jpg" },

            // Menu 15: Dinner at Restaurant 5
            new SubSectionVM { Id = new Guid("45f6d5a2-38e3-4d08-a45d-6eb365e6b37d"), Name = "Veg", Description = "Vegetarian dinner options.", MenuId = new Guid("c1ff155b-2747-484f-93a0-0cfe19b44430"), Image = "veg_dinner.jpg" },
            new SubSectionVM { Id = new Guid("243a4aae-ebf7-4c7b-8469-7439b8dc5c5b"), Name = "Non-Veg", Description = "Non-vegetarian dinner options.", MenuId = new Guid("c1ff155b-2747-484f-93a0-0cfe19b44430"), Image = "non_veg_dinner.jpg" }
        };
        public IActionResult Index(Guid menuId)
        {
            var subSection = subSectionsForAllMenus.Where(x => x.MenuId == menuId);
            return View(subSection);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubSectionCreateVM createVM)
        {

            //write code to create menu

            return Content("Ok");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, SubSectionEditVM editVM)
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
