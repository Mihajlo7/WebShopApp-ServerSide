using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Persons.Domain.Domain
{
    public class BussinessEntitityCreditCard: IEntity
    {
        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        public Guid CreditCardId { get; set; }
        public CreditCard CreditCard { get; set;}
    }
}
