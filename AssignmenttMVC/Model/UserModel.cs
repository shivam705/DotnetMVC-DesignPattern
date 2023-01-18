using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmenttMVC.Model
{
    
    public class UserModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter Username.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter Password.")]
        public string Password { get; set; }
    }
}
