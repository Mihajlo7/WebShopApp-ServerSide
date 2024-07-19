using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMediator;
using Persons.Core.Dto.Registration.Request;
using Persons.Core.Dto.Registration.Response;

namespace Persons.Mediator.Commands
{
    public sealed record RegisterPersonCommand(RegisterPersonDTO registerPerson) : ICommand<RegisterResponseDTO>;
    
}
