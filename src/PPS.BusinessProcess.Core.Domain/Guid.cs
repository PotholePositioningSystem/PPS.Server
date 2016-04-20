using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PPS.BusinessProcess.Core.Domain
{
    public class GuidRole : IdentityRole<Guid, GuidUserRole>
    {
        public GuidRole()
        {
            Id = GuidComb.Generate();
        }

        public GuidRole(string name) : this()
        {
            Name = name;
        }
    }

    public class GuidUserRole : IdentityUserRole<Guid>
    {
    }

    public class GuidUserClaim : IdentityUserClaim<Guid>
    {
    }

    public class GuidUserLogin : IdentityUserLogin<Guid>
    {
    }

}
