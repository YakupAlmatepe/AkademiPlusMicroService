﻿using AkademiPlusMicrpservice.Order.Core.Application.DTOs.OrderDetailDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Commands
{
    public class CreateOrderDetailCommandRequest : IRequest<CreateOrderDetailDto>
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public int OrderingId { get; set; }
    }
}