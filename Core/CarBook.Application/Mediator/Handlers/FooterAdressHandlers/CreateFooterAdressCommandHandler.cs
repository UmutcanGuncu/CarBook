using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.FooterAdressCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAdressHandlers
{
    public class CreateFooterAdressCommandHandler : IRequestHandler<CreateFooterAdressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;

        public CreateFooterAdressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAdressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAdress
            {
                Adress = request.Adress,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
        }
    }
}

