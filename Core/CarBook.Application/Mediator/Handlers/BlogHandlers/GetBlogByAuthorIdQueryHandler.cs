using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.BlogQueries;
using CarBook.Application.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, GetBlogByAuthorIdQueryResult>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<GetBlogByAuthorIdQueryResult> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _blogRepository.GetBlogByAuthorId(request.AuthorId, request.BlogId);
            return new GetBlogByAuthorIdQueryResult
            {
                AuthorName = value.Author.Name,
                AuthorDescription = value.Author.Description,
                AuthorImageUrl = value.Author.ImageUrl,
                AuthorId = value.AuthorId
            };
        }
    }
}

