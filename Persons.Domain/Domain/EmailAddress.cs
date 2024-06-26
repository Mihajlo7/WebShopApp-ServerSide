using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class EmailAddress: BusinessEntity
    {
        public int EmailAddressPromotion { get; set; }
        public string Email {  get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
