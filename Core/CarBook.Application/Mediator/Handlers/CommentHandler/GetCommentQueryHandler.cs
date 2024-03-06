using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.CommentQueries;
using CarBook.Application.Mediator.Results.CommentResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.CommentHandler
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCommentQueryResult
            {
                Id = x.Id,
                BlogId = x.BlogId,
                CreateDate = x.CreateDate,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).ToList();
        }
    }
}

