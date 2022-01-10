using System;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
namespace DAL
{
    public class SalaryInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalarySheetNo { get; set; }
        public int EmpCode { get; set; }
        public DateTime? DateOfSalary { get; set; }
        public decimal Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? Da { get; set; }
        public decimal? NetSalary { get; set; }

        public virtual EmpProfile EmpProfile { get; set; }
    }
}