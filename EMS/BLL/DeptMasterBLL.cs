using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DeptMasterBLL
    {
        DeptMasterDALRepository DeptMasterDAL = new DeptMasterDALRepository();

        public bool SaveDept(DeptMaster deptMaster)
        {
            return DeptMasterDAL.SaveDept(deptMaster);
        }

        public bool DeleteDept(DeptMaster deptMaster)
        {
            return DeptMasterDAL.DeleteDept(deptMaster);
        }

        public bool UpdateDept(DeptMaster deptMaster)
        {
            return DeptMasterDAL.UpdateDept(deptMaster);
        }

        public DeptMaster GetDeptById(int DeptId)
        {
            return DeptMasterDAL.GetDeptMaster(DeptId);
        }

        public ICollection<DeptMaster> GetAllDept()
        {
            return DeptMasterDAL.GetAll();
        }
    }
}
