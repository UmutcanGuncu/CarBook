using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.BlogQueries;
using CarBook.Application.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithAuthorAndCategoryQueryHandler : IRequestHandler<GetBlogWithAuthorAndCategoryQuery, List<GetBlogWithAuthorAndCategoryQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogWithAuthorAndCategoryQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetBlogWithAuthorAndCategoryQueryResult>> Handle(GetBlogWithAuthorAndCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetBlogListWithAuthorAndCategory();
            return values.Select(x => new GetBlogWithAuthorAndCategoryQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                CreatedDate = x.CreatedDate,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                CoverImageUrl = x.CoverImageUrl,
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }).ToList();
        }
    }
}

