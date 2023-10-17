using AkademiPlusMicrpservice.Order.Core.Application.DTOs.AdressDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAddressQueryRequest : IRequest<ResultAddressDto>
    {
        public GetAddressQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}