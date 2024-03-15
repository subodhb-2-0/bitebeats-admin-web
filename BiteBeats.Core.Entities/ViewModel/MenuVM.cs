using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Entities.ViewModel
{
    public class MenuVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid RestaurantId { get; set; }
    }
    public class MenuEditVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = null;
        public IFormFile ImageFile { get; set; }
        public Guid RestaurantId { get; set; }
    }
    public class MenuCreateVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = null;
        public IFormFile ImageFile { get; set; }
        public Guid RestaurantId { get; set; }
    }
}
