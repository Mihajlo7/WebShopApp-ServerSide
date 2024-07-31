using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMediator;
using Persons.Core.Dto.Login;

namespace Persons.Mediator.Commands
{
    public record LoginPersonCommand (LoginPersonDTO loginPerson) : ICommand<LoginResponseDTO>;
    
}
