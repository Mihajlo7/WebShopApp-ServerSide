using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Core.Dto;
using Persons.Core.Dto.Registration.Request;
using Persons.Core.Dto.Registration.Response;

namespace Persons.Service
{
    public interface IPersonService
    {
        public Task<IEnumerable<CountryWithoutAddressDTO>> GetAllCountries();
        public Task<RegisterResponseDTO> Register(RegisterPersonDTO registerPerson);
        
    }
}
