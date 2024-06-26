using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class BusinessEntityAdress : BusinessEntity
    {
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
