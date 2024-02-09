using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.FooterAdressCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAdressHandlers
{
    public class RemoveFooterAdressCommandHandler : IRequestHandler<RemoveFooterAdressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;

        public RemoveFooterAdressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFooterAdressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}

