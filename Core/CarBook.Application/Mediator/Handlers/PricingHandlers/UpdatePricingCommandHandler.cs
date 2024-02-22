using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.PricingCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public UpdatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.CarId = request.CarId;
            value.AmountDay = request.AmountDay;
            value.AmountHour = request.AmountHour;
            value.AmountWeek = request.AmountWeek;
            await _repository.UpdateAsync(value);
        
        }
    }
}

