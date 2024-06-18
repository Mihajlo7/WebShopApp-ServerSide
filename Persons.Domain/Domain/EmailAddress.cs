using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class EmailAddress: BusinessEntity
    {
        public int EmailAddressId { get; set; }
        public string Email {  get; set; }
    }
}
