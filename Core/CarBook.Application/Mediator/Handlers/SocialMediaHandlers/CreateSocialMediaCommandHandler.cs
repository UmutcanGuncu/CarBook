using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.SocialMediaCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.SocialMediaHandlers
{
	public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Name = request.Name,
                IconUrl = request.IconUrl,
                Url = request.Url
            });
        }
    }
}

