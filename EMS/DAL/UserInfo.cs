using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL
{
    public class UserInfo
    {
        [Key]
       
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
