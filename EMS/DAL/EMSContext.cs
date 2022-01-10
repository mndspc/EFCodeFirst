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
        public EMSContext():base ("name=NordicEMSCon")
        {

        }
        public DbSet<DeptMaster> DeptMasters { get; set; }

        public DbSet<EmpProfile> EmpProfiles { get; set; }

        public DbSet<SalaryInfo> SalaryInfoes { get; set; }

        public DbSet<UserInfo> UserInfoes { get; set; }
    }
}
