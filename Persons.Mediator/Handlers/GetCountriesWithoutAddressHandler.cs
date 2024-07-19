using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GenericInfrastructure;
using GenericMediator;
using Persons.Core.Dto;
using Persons.Core.Mapper;
using Persons.Domain.Domain;
using Persons.Infrastructure;
using Persons.Mediator.Queries;

namespace Persons.Mediator.Handlers
{
    public class GetCountriesWithoutAddressHandler : IQueryHandler<GetCountriesWthoutAddressQuery, IEnumerable<CountryWithoutAddressDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<PersonsDBContext> _unitOfWork;

        public GetCountriesWithoutAddressHandler(IUnitOfWork<PersonsDBContext> unitOfWork)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PersonMappingProfile>();
            });

            _mapper = config.CreateMapper();
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CountryWithoutAddressDTO>> Handle(GetCountriesWthoutAddressQuery request, CancellationToken cancellationToken)
        {
            var response = await _unitOfWork.GetRepository<Country>().GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<CountryWithoutAddressDTO>>(response);
        }
    }
}
