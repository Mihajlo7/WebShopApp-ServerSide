﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class Country 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryRegionCode { get; set; }
    }
}
