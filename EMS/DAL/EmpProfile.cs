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

        [Required]
        [StringLength(maximumLength:50,MinimumLength =10)]
        public string EmpName { get; set; }

        [DataType(DataType.DateTime)]
        public System.DateTime DateOfBirth { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^[0-9]\d*$")]
        public int DeptCode { get; set; }
        public virtual DeptMaster DeptMaster { get; set; }

        public virtual ICollection<SalaryInfo> SalaryInfoes { get; set; }

    }
}