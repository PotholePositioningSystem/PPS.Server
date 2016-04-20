using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using PPS.BusinessProcess.Core.Domain;

namespace PPS.BusinessProcess.Infrastructure.Repository
{
    public class PPSContext : IdentityDbContext<User, GuidRole, Guid, GuidUserLogin, GuidUserRole, GuidUserClaim>
    {
        public DbSet<Issue> Issues { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>().Property(i => i.Latitude).HasPrecision(18, 9);
            modelBuilder.Entity<Issue>().Property(i => i.Longitude).HasPrecision(18, 9);
        }
    }
}
