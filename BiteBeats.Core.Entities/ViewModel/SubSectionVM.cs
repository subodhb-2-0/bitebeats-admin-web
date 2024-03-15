using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Entities.ViewModel
{
    public class SubSectionVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid MenuId { get; set; }
        public string Image { get; set; }
    }
    public class SubSectionEditVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid MenuId { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
    public class SubSectionCreateVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid MenuId { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
