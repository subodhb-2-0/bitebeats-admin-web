using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Entities.ViewModel
{
    public class DishVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Guid SubSectionId { get; set; }
        public IEnumerable<SizeVM> Sizes { get; set; }
        public IEnumerable<ExtrasVM> Extras { get; set; }
    }
    public class DishCreateVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = null;
        public IFormFile ImageFile { get; set; }
        public decimal Price { get; set; }
        public Guid SubSectionId { get; set; }
    }
    public class DishEditVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = null;
        public IFormFile ImageFile { get; set; }
        public decimal Price { get; set; }
        public Guid SubSectionId { get; set; }
    }
}
