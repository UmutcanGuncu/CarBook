using System;
using CarBook.Application.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.AuthorQueris
{
	public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
	{
        public GetAuthorByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
		
	}
}

