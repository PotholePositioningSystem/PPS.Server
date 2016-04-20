using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PPS.BusinessProcess.Core.Domain
{
    public sealed class User : IdentityUser<Guid, GuidUserLogin, GuidUserRole, GuidUserClaim>
    {
        public User()
        {
            Id = GuidComb.Generate();

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageBlobName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? AddedOn { get; set; }

    }
}




