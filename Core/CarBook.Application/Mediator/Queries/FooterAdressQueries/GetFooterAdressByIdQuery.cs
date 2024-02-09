using System;
using CarBook.Application.Mediator.Results.FooterAdressResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.FooterAdressQueries
{
	public class GetFooterAdressByIdQuery : IRequest<GetFooterAdressByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetFooterAdressByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

