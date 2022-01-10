using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class EmpProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int DeptCode { get; set; }
        public virtual DeptMaster DeptMaster { get; set; }

        public virtual ICollection<SalaryInfo> SalaryInfoes { get; set; }

    }
}