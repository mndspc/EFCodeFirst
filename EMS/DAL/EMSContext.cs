using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DAL
{
    public class EMSContext:DbContext
    {
        public EMSContext():base ("name=EMSContext")
        {

        }
        public DbSet<DeptMaster> DeptMasters { get; set; }

        public DbSet<EmpProfile> EmpProfiles { get; set; }

        public DbSet<SalaryInfo> SalaryInfoes { get; set; }

        public DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Use alias for DeptMaster
            //modelBuilder.Entity<DeptMaster>().ToTable("DeptMaster");
            //modelBuilder.Entity<DeptMaster>().HasKey(x=>x.DeptCode);

            //modelBuilder.Entity<EmpProfile>().ToTable("EmpProfile");
            //modelBuilder.Entity<EmpProfile>().HasKey(x=>x.EmpCode);

            //modelBuilder.Entity<DeptMaster>().HasMany(x => x.EmpProfiles);
        }
    }
}
