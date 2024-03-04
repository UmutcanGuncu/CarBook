using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.BlogCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.AuthorId = request.AuthorId;
            value.CategoryId = request.CategoryId;
            value.CoverImageUrl = request.CoverImageUrl;
            value.CreatedDate = request.CreatedDate;
            value.Title = request.Title;
            value.Description = request.Description;
            await _repository.UpdateAsync(value);
        }
    }
}

