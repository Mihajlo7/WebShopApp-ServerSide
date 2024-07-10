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
   
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public DateTime BirthDay { get; set; }

        
        public string Email {  get; set; }

        
        public string Password { get; set; }

        
        public string ConfirmedPassword { get; set; }
        
        
        public string Telephone { get; set; }
        
        public string Address { get; set; }
        public int CountyId { get; set; }

        public string Type { get; set; }
        public string Number { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }

    }
    
}
