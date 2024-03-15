using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Entities.ViewModel
{
    public class UserRestaurantVM
    {
        public RestaurantVM Restaurant { get; set; }
        public UserVM User { get; set; }
    }
}
