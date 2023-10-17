using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AkademiPlusMicrpservice.Order.Core.Application.DTOs.AdressDto;
using AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Queries;
using AkademiPlusMicrpservice.Order.Core.Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, List<ResultAddressDto>>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAllAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultAddressDto>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultAddressDto>>(values);
        }
    }

}