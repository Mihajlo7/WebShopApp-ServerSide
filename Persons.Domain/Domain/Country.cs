﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Persons.Domain.Domain
{
    public class Country : IEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryRegionCode { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
