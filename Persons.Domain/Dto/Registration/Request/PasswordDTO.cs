using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Core.Dto.Registration.Request
{
    public class PasswordDTO
    {
        public string NewPassword {  get; set; }
        public string ConfirmedPassword { get; set; }
    }
}
