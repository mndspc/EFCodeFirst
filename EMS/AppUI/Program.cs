using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
namespace AppUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeptMasterBLL deptMasterBLL = new DeptMasterBLL();
            DeptMaster deptMaster = new DeptMaster {DeptCode=1,DeptName="Hr" };
           var result= deptMasterBLL.SaveDept(deptMaster);
            Console.WriteLine(result?"Database Created":"Error");
            Console.ReadLine();

        }
    }
}
