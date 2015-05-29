using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.Models
{
    public class User
    {
        [Required]
        
        [Display(Name="User Name:")]
        public string username { get; set; }
        [Required]
        [Compare("username", ErrorMessage = "username and pwd hsould match")]
        [Display(Name="Password:")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [Display(Name="Email Id:")][DataType(DataType.EmailAddress)]
        public string mailid { get; set; }
    }
}
