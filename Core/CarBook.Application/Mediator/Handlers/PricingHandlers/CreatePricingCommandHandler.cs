using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.PricingCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public CreatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Pricing
            {
                AmountDay = request.AmountDay,
                AmountHour = request.AmountHour,
                AmountWeek = request.AmountWeek,
                CarId = request.CarId
            });
        }
    }
}

