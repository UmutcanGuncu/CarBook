using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.BlogQueries;
using CarBook.Application.Mediator.Results.BlogResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                CreatedDate = value.CreatedDate,
                AuthorId = value.AuthorId,
                CategoryId = value.CategoryId,
                Id = value.Id,
                CoverImageUrl = value.CoverImageUrl,
                Title = value.Title,
                Description = value.Description
            };
        }
    }
}

