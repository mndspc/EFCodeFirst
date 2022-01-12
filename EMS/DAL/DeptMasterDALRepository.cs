using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeptMasterDALRepository : IDeptMasterDALRepository<DeptMaster>
    {
   
        public bool SaveDept(DeptMaster deptMaster)
        {
            try
            {
                using (EMSContext dbContext=new EMSContext())
                {
                    dbContext.DeptMasters.Add(deptMaster);
                    dbContext.SaveChanges();
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool DeleteDept(DeptMaster deptMaster)
        {
            try
            {
                using (EMSContext dbContext = new EMSContext())
                {
                    var dept = dbContext.DeptMasters.Where(x => x.DeptCode == deptMaster.DeptCode).FirstOrDefault();
                    if (dept != null)
                    {
                        dbContext.DeptMasters.Remove(deptMaster);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateDept(DeptMaster deptMaster)
        {
            try
            {
                using (EMSContext dbContext = new EMSContext())
                {
                    var dept = dbContext.DeptMasters.Where(x => x.DeptCode == deptMaster.DeptCode).FirstOrDefault();
                    if (dept != null)
                    {
                        dept.DeptCode  =deptMaster.DeptCode;
                        dept.DeptName = deptMaster.DeptName;
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DeptMaster GetDeptMaster(int DeptId)
        {
            try
            {
                using (EMSContext dbContext = new EMSContext())
                {
                    var dept = dbContext.DeptMasters.Where(x => x.DeptCode == DeptId).FirstOrDefault();
                    if (dept != null)
                    {

                        return dept;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ICollection<DeptMaster> GetAll()
        {
            try
            {
                using (EMSContext dbContext = new EMSContext())
                {
                    var depts = dbContext.DeptMasters.ToList();
                    if (depts != null)
                    {

                        return depts;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
