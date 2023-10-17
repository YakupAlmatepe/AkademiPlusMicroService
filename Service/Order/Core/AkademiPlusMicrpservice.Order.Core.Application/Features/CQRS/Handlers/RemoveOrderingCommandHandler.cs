﻿using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicrpservice.Order.Core.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicrpservice.Order.Core.Application.Features.CQRS.Handlers
{
    public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommandRequest>
    {
        private readonly IRepository<Ordering> _repository;

        public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            _repository.DeleteAsync(value);
        }
    }

}