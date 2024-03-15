using BiteBeats.Core.Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BiteBeats.Web.Controllers
{
    public class DishController : Controller
    {
        private static IEnumerable<ExtrasVM> extras = new List<ExtrasVM>
        {
            new ExtrasVM { Id = new Guid("4f6a3b24-4bb7-4c3c-ba24-5b1b962ce73f"), Name = "Extra Cheese", Price = 1.50m },
            new ExtrasVM { Id = new Guid("03d74b4e-4b64-4b61-b3c2-53d9f9a73f28"), Name = "Bacon Strips", Price = 2.00m },
            new ExtrasVM { Id = new Guid("f072e1c2-b5d5-45ae-a0f0-3e27ef7383de"), Name = "Avocado Slices", Price = 1.75m }
        };

        private static IEnumerable<SizeVM> sizes = new List<SizeVM>
        {
            new SizeVM { Id = new Guid("042139e9-d5b2-4875-9bdc-287e85af7515"), Name = "Small", Price = 9.99m },
            new SizeVM { Id = new Guid("b7fbcd6d-4b7a-41d4-a7d3-0cf4fb67da9c"), Name = "Regular", Price = 12.99m },
            new SizeVM { Id = new Guid("e2c5560e-426a-486f-89c2-1ff58e2f11d3"), Name = "Large", Price = 15.99m }
        };
        private IEnumerable<DishVM> dishes = new List<DishVM>
        {
            // Subsection: Veg
            new DishVM { Id = new Guid("90c5d9e8-05c1-4f63-a3b4-476c5ac9140d"), Name = "Veggie Omelette", Description = "Fluffy omelette made with assorted vegetables.", Image = "veggie_omelette.jpg", Price = 8.99m, SubSectionId = new Guid("a3702ae4-fa2f-4d48-a1d0-2cda1b572b13") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("dbb17462-fc1e-45ec-b9ed-5a67e74329f5"), Name = "Vegetable Curry", Description = "Delicious curry made with mixed vegetables.", Image = "vegetable_curry.jpg", Price = 10.99m, SubSectionId = new Guid("a3702ae4-fa2f-4d48-a1d0-2cda1b572b13") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("36a5f336-2444-4036-b9d1-442d5c1a6888"), Name = "Garden Salad", Description = "Fresh salad made with lettuce, tomatoes, cucumbers, and dressing.", Image = "garden_salad.jpg", Price = 6.99m, SubSectionId = new Guid("a3702ae4-fa2f-4d48-a1d0-2cda1b572b13") , Sizes = sizes, Extras = extras},

            // Subsection: Non-Veg
            new DishVM { Id = new Guid("ad0a7a44-c53e-4c84-bc8b-3dfb6d1e1f6d"), Name = "Chicken Sandwich", Description = "Grilled chicken sandwich with lettuce, tomato, and mayonnaise.", Image = "chicken_sandwich.jpg", Price = 9.99m, SubSectionId = new Guid("2d3bc4d2-98bb-4b82-8231-24b1dc2f1b55") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("6e88b4d2-6d52-4609-b3cb-3d8a87a011ab"), Name = "Beef Burger", Description = "Juicy beef burger with cheese, lettuce, tomato, and onion.", Image = "beef_burger.jpg", Price = 11.99m, SubSectionId = new Guid("2d3bc4d2-98bb-4b82-8231-24b1dc2f1b55") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("5d695724-5bb3-457e-bc57-cd89b3dd22ad"), Name = "Fish Tacos", Description = "Crispy fish tacos with cabbage slaw and chipotle mayo.", Image = "fish_tacos.jpg", Price = 12.99m, SubSectionId = new Guid("2d3bc4d2-98bb-4b82-8231-24b1dc2f1b55") , Sizes = sizes, Extras = extras},

            // Subsection: Hot
            new DishVM { Id = new Guid("3a79e2c8-40f7-4295-a17d-4956f08b1d6c"), Name = "Spicy Chicken Curry", Description = "Spicy chicken curry served with rice or naan bread.", Image = "spicy_chicken_curry.jpg", Price = 13.99m, SubSectionId = new Guid("655a8dd8-7832-49a3-830f-3f9727cbaf23") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("3bdc0590-2e2e-4547-9e1b-d49d9904c4e9"), Name = "Chili Con Carne", Description = "Hearty beef chili served with rice or cornbread.", Image = "chili_con_carne.jpg", Price = 11.99m, SubSectionId = new Guid("655a8dd8-7832-49a3-830f-3f9727cbaf23") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("6f4b124b-8eac-4c4d-b8f8-02debbf19d54"), Name = "Hot Wings", Description = "Spicy chicken wings served with ranch dressing.", Image = "hot_wings.jpg", Price = 9.99m, SubSectionId = new Guid("655a8dd8-7832-49a3-830f-3f9727cbaf23") , Sizes = sizes, Extras = extras},

            // Subsection: Cold
            new DishVM { Id = new Guid("9df61c15-0545-499b-92c8-4d67cf74750d"), Name = "Greek Yogurt Parfait", Description = "Layers of Greek yogurt, granola, and fresh fruit.", Image = "greek_yogurt_parfait.jpg", Price = 7.99m, SubSectionId =new Guid("bc4e61ed-937d-4f5b-b62e-95cb62893d1a") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("7c3af6ef-fb27-4f23-a916-b2cc69e4b7fd"), Name = "Caprese Panini", Description = "Panini sandwich with mozzarella, tomato, basil, and balsamic glaze.", Image = "caprese_panini.jpg", Price = 8.99m, SubSectionId = new Guid("bc4e61ed-937d-4f5b-b62e-95cb62893d1a") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("b40531f2-232b-4cd4-aa25-bec0f86543cf"), Name = "Iced Coffee", Description = "Chilled coffee served with ice cubes and cream.", Image = "iced_coffee.jpg", Price = 4.99m, SubSectionId =new Guid("bc4e61ed-937d-4f5b-b62e-95cb62893d1a") , Sizes = sizes, Extras = extras},

            // Subsection: Spicy
            new DishVM { Id = new Guid("b8e183a6-5c32-4f3b-af54-5f1d8126bc04"), Name = "Spicy Tofu Stir-Fry", Description = "Tofu stir-fry with mixed vegetables and spicy sauce.", Image = "spicy_tofu_stir_fry.jpg", Price = 10.99m, SubSectionId = new Guid("deea9b2b-fb9b-4701-8a65-c646b8f27f9b") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("90e72a7c-0bb8-437b-9017-50063e01c5c5"), Name = "Spicy Pork Ramen", Description = "Japanese noodle soup with spicy pork broth.", Image = "spicy_pork_ramen.jpg", Price = 12.99m, SubSectionId = new Guid("deea9b2b-fb9b-4701-8a65-c646b8f27f9b") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("90c06d5c-5e10-4bfc-bc67-9f7d929f7c27"), Name = "Spicy Chicken Wrap", Description = "Grilled chicken wrap with spicy sauce, lettuce, and tomato.", Image = "spicy_chicken_wrap.jpg", Price = 9.99m, SubSectionId = new Guid("deea9b2b-fb9b-4701-8a65-c646b8f27f9b") , Sizes = sizes, Extras = extras},

            // Subsection: Sweet
            new DishVM { Id = new Guid("de90a930-2a30-45b5-8c3f-69c44a8059a1"), Name = "Chocolate Cake", Description = "Rich chocolate cake topped with ganache.", Image = "chocolate_cake.jpg", Price = 8.99m, SubSectionId = new Guid("22af4225-3773-4351-bba7-3e8e1ac73911") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("9e6879c4-b8f4-4a52-9a28-28b99f5484c4"), Name = "Fruit Tart", Description = "Buttery tart filled with custard and fresh fruit.", Image = "fruit_tart.jpg", Price = 7.99m, SubSectionId = new Guid("22af4225-3773-4351-bba7-3e8e1ac73911") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("3c22a947-bd9f-4a30-8543-e2d58e1a5a43"), Name = "Vanilla Ice Cream", Description = "Creamy vanilla ice cream served with chocolate sauce.", Image = "vanilla_ice_cream.jpg", Price = 5.99m, SubSectionId = new Guid("22af4225-3773-4351-bba7-3e8e1ac73911") , Sizes = sizes, Extras = extras},

            // Subsection: Healthy
            new DishVM { Id = new Guid("eac190a2-1c1b-4963-8649-fd9b66c4cc7e"), Name = "Quinoa Salad", Description = "Quinoa salad with mixed vegetables and lemon vinaigrette.", Image = "quinoa_salad.jpg", Price = 9.99m, SubSectionId = new Guid("142ee856-cb1b-4815-84bb-d7f5ff83e9a5") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("91b71599-d2d0-4f59-bf40-8d9f1684d4c3"), Name = "Grilled Chicken Salad", Description = "Grilled chicken breast served on a bed of mixed greens.", Image = "grilled_chicken_salad.jpg", Price = 11.99m, SubSectionId = new Guid("142ee856-cb1b-4815-84bb-d7f5ff83e9a5") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("5e028482-8554-4da9-ae16-4d7b3282f5ec"), Name = "Smoothie Bowl", Description = "Smoothie bowl topped with granola, fruit, and seeds.", Image = "smoothie_bowl.jpg", Price = 8.99m, SubSectionId = new Guid("142ee856-cb1b-4815-84bb-d7f5ff83e9a5") , Sizes = sizes, Extras = extras},

            // Subsection: Comfort
            new DishVM { Id = new Guid("20cc5586-43e1-41d3-9ec1-531ea9e24d02"), Name = "Mac and Cheese", Description = "Classic macaroni and cheese baked to perfection.", Image = "mac_and_cheese.jpg", Price = 10.99m, SubSectionId = new Guid("4c470160-ff7d-4b2c-bd81-74d4952856f9") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("30f4e3f7-dc2d-4e9b-84b3-bb3023a036df"), Name = "Chicken Pot Pie", Description = "Savory chicken pot pie with flaky crust.", Image = "chicken_pot_pie.jpg", Price = 12.99m, SubSectionId = new Guid("4c470160-ff7d-4b2c-bd81-74d4952856f9") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("1b67a51a-7920-4538-97f6-2e1b3a1fc2a5"), Name = "Mashed Potatoes", Description = "Creamy mashed potatoes served with gravy.", Image = "mashed_potatoes.jpg", Price = 6.99m, SubSectionId = new Guid("4c470160-ff7d-4b2c-bd81-74d4952856f9") , Sizes = sizes, Extras = extras},

            // Subsection: Exotic
            new DishVM { Id = new Guid("1feffcd7-39ff-4ed7-804d-43dd25d1c717"), Name = "Sushi Platter", Description = "Assorted sushi rolls served with soy sauce and wasabi.", Image = "sushi_platter.jpg", Price = 14.99m, SubSectionId = new Guid("f637dc65-0a93-47ad-bfce-4f1ad59d2e71") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("f0052c29-0d78-4f5a-9f52-69af9bfad47d"), Name = "Pad Thai", Description = "Thai stir-fried noodles with shrimp, tofu, and peanuts.", Image = "pad_thai.jpg", Price = 11.99m, SubSectionId = new Guid("f637dc65-0a93-47ad-bfce-4f1ad59d2e71") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("3f8b62d1-22ec-4b94-bdb2-c3d22dfcf932"), Name = "Lamb Curry", Description = "Spicy lamb curry served with rice or naan bread.", Image = "lamb_curry.jpg", Price = 13.99m, SubSectionId = new Guid("f637dc65-0a93-47ad-bfce-4f1ad59d2e71") , Sizes = sizes, Extras = extras},

            // Subsection: Traditional
            new DishVM { Id = new Guid("5fe70eb3-c20b-4532-b0e0-8c47a35e2f92"), Name = "Shepherd's Pie", Description = "Hearty pie filled with ground meat and mashed potatoes.", Image = "shepherds_pie.jpg", Price = 11.99m, SubSectionId = new Guid("cd9cb52a-625d-4b80-ae12-92bbef4c4c35") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("a68cb4fd-68a2-42aa-9d2f-9be8235e04ae"), Name = "Fish and Chips", Description = "Crispy fried fish served with French fries.", Image = "fish_and_chips.jpg", Price = 12.99m, SubSectionId = new Guid("cd9cb52a-625d-4b80-ae12-92bbef4c4c35") , Sizes = sizes, Extras = extras},
            new DishVM { Id = new Guid("15b36446-65e5-41d8-8676-63cc51c96f35"), Name = "Bangers and Mash", Description = "Sausages served with mashed potatoes and onion gravy.", Image = "bangers_and_mash.jpg", Price = 10.99m, SubSectionId = new Guid("cd9cb52a-625d-4b80-ae12-92bbef4c4c35") , Sizes = sizes, Extras = extras}
        };

        public async Task<IActionResult> Index(Guid subSectionId)
        {
            var dishestosend = dishes.Where(x => x.SubSectionId == subSectionId);
            return View(dishestosend);
        }
        [HttpPost]
        public async Task<IActionResult> Create(DishCreateVM createVM)
        {

            //write code to create menu

            return Content("Ok");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, DishEditVM editVM)
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
