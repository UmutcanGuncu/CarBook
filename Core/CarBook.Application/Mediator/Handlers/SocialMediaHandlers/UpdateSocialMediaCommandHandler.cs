using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.SocialMediaCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.SocialMediaHandlers
{
	public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            value.IconUrl = request.IconUrl;
            value.Url = request.Url;
            await _repository.UpdateAsync(value);
        }
    }
}

