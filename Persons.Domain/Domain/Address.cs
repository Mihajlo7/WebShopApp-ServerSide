using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class Address : BusinessEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set;}
        public string City { get; set; }
        public string PostalCode { get; set; }

        public virtual ICollection<BusinessEntityAdress> Adresses { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}
