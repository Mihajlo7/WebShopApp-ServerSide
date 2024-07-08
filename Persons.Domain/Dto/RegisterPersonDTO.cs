using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Core.Dto
{
    public class RegisterPersonDTO
    {
        [Required (ErrorMessage ="First Name is required")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Last Name is required")]
        string LastName { get; set; }

        [Required (ErrorMessage = "Birth day is required")]
        DateTime BirthDay { get; set; }

        [Required(ErrorMessage ="Email is required")]
        public string Email {  get; set; }

        [Required (ErrorMessage ="Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm Password is required")]
        public string ConfirmedPassword { get; set; }
        
        [Required(ErrorMessage = "Telephone is required")]
        public string Telephone { get; set; }
        
        public string Address { get; set; }
        public int CountyId { get; set; }

        public string Type { get; set; }
        public string Number { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }

    }
    
}
