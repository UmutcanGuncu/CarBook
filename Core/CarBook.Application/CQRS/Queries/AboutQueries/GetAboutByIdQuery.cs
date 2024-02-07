using System;
namespace CarBook.Application.CQRS.Queries.AboutQueries
{
	public class GetAboutByIdQuery
	{
        public GetAboutByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

