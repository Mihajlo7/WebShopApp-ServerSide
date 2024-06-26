﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class Person : BusinessEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<BusinessEntityAdress> Adresses { get; set;}
        public virtual ICollection<Password> Passwords { get; set; }
        public virtual ICollection<BussinessEntitityCreditCard> CreditCards { get; set; }
        public virtual EmailAddress EmailAddress { get; set; }
    }
}
