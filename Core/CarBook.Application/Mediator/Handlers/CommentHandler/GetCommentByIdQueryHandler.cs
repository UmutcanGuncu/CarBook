using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.CommentQueries;
using CarBook.Application.Mediator.Results.CommentResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.CommentHandler
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueyResult>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentByIdQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<GetCommentByIdQueyResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCommentByIdQueyResult
            {
                Id = value.Id,
                BlogId = value.BlogId,
                Description = value.Description,
                CreateDate = value.CreateDate,
                ImageUrl = value.ImageUrl,
                Name = value.Name
            };
        }
    }
}

