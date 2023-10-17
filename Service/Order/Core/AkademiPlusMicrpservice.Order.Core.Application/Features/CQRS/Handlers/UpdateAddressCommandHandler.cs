using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AkademiPlusMicrpservice.Order.Core.Application.DTOs.AdressDto;
using AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Commands;
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
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressDto>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public UpdateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UpdateAddressDto> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var value = new Address
            {
                AddressId = request.AddressId,
                City = request.City,
                Detail = request.Detail,
                District = request.District,
                UserId = request.UserId,
            };
            await _repository.UpdateAsync(value);
            return _mapper.Map<UpdateAddressDto>(value);
        }
    }

}