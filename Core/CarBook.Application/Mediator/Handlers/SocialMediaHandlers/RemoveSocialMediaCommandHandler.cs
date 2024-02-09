using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.SocialMediaCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.SocialMediaHandlers
{
	public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

        public RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}

