using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDeptMasterDALRepository<DeptMaster>
    {
        bool SaveDept(DeptMaster deptMaster);

        bool DeleteDept(DeptMaster deptMaster);

        bool UpdateDept(DeptMaster deptMaster);

        DeptMaster GetDeptMaster(int DeptId);

        ICollection<DeptMaster> GetAll();
    }
}
