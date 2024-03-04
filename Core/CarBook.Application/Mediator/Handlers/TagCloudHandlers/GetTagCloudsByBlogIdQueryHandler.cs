using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Mediator.Results.TagCloudResult;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudsByBlogIdQueryHandler : IRequestHandler<GetTagCloudsByBlogIdQuery, List<GetTagCloudByIdQueryResult>>
    {
        private readonly ITagCloudRepository _tagCloudRepository;

        public GetTagCloudsByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository)
        {
            _tagCloudRepository = tagCloudRepository;
        }

       
        public async Task<List<GetTagCloudByIdQueryResult>> Handle(GetTagCloudsByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _tagCloudRepository.GetTagCloudsByBlogId(request.BlogId);
            return values.Select(x => new GetTagCloudByIdQueryResult
            {
                Id = x.Id,
                BlogId = x.BlogId,
                Title = x.Title

            }).ToList();
        }
    }
}

