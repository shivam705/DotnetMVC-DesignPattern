using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmenttMVC.Model
{
    public class RegisterUserModel
    {
        //[UserValidator]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter Username name.")]
        public string UserName { get; set; }

        //[UserValidator]
        [EmailAddress]
        [Required(ErrorMessage = "Please enter Email Address.")]
        public string EmailId { get; set; }

        [MinLength(5)]
        [Required(ErrorMessage = "Please enter Username Passward.")]
        public string Password { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public EventsModel EventsModel { get; set; }
    }
}
