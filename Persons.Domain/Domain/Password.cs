﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Domain.Domain
{
    public class Password : BusinessEntity
    {
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
