using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.BlogQueries;
using CarBook.Application.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogListWithAuthorAndCategoryQueryHandler : IRequestHandler<GetLast3BlogListWithAuthorAndCategoryQuery, List<GetLast3BlogListWithAuthorAndCategoryQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetLast3BlogListWithAuthorAndCategoryQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetLast3BlogListWithAuthorAndCategoryQueryResult>> Handle(GetLast3BlogListWithAuthorAndCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetLast3BlogListWithAuthorAndCategory();
            return values.Select(x => new GetLast3BlogListWithAuthorAndCategoryQueryResult
            {
                Id = x.Id,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                CreatedDate = x.CreatedDate,
                CoverImageUrl = x.CoverImageUrl,
                Title = x.Title,
                Description = x.Description

            }).ToList();
        }
    }
}

