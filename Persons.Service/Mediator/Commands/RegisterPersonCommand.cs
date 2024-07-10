﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMediator;
using Persons.Core.Dto;

namespace Persons.Service.Mediator.Commands
{
    public sealed record RegisterPersonCommand(RegisterPersonDTO registerPerson) : ICommand<RegisterResponseDTO>;
    
}
