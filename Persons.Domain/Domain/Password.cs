using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Persons.Domain.Domain
{
    public class Password : IEntity
    {
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsActive { get; set; }

        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
