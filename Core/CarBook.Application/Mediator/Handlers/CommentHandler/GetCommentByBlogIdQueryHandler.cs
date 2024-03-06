using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.CommentQueries;
using CarBook.Application.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.CommentHandler
{
    public class GetCommentByBlogIdQueryHandler : IRequestHandler<GetCommentByBlogIdQuery, List<GetCommentByBlogIdQueryResult>>
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentByBlogIdQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<GetCommentByBlogIdQueryResult>> Handle(GetCommentByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _commentRepository.GetCommentByBlogId(request.BlogId);
            return values.Select(x => new GetCommentByBlogIdQueryResult
            {
                Id = x.Id,
                Description = x.Description,
                CreateDate = x.CreateDate,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).ToList();
        }
    }
}

