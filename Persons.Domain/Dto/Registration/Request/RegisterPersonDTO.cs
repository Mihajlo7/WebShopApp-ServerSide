using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Core.Dto.Registration.Request
{
    public class RegisterPersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Telephone { get; set; }
        public PasswordDTO Password { get; set; }
        public EmailAddressDTO EmailAddress { get; set; }
        public AddressDTO Address { get; set; }
        public CreditCardDTO CreditCard { get; set; }
        

    }

}
