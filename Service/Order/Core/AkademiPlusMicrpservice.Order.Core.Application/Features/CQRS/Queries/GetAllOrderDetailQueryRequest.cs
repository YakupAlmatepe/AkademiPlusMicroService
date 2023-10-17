using AkademiPlusMicrpservice.Order.Core.Application.DTOs.OrderDetailDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAllOrderDetailQueryRequest : IRequest<List<ResultOrderDetailDto>>
    {
    }
}