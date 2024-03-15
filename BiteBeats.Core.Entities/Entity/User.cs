using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteBeats.Core.Entities.Entity
{
    public class User : BaseDbEntity
    {
        public string IdentityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public bool IsBanned { get; set; }
    }
}
