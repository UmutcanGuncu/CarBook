using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.BlogCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                AuthorId = request.AuthorId,
                CategoryId = request.CategoryId,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = DateTime.Now,
                Title = request.Title,
                Description = request.Description
            });
        }
    }
}

