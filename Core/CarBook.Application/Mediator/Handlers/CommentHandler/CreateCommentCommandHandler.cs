using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.CommentCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.CommentHandler
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public CreateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
                BlogId = request.BlogId,
                Description = request.Description,
                CreateDate = DateTime.Now,
                ImageUrl = request.ImageUrl,
                Name = request.Name

            });
        }
    }
}

