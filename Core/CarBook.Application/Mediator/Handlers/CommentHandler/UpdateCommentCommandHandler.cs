using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.CommentCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.CommentHandler
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public UpdateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.BlogId = request.BlogId;
            value.Description = request.Description;
            value.ImageUrl = request.ImageUrl;
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}

