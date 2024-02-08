using System;
namespace CarBook.Application.CQRS.Queries.CarQueries
{
	public class GetCarByIdQuery
	{
		public Guid Id { get; set; }

        public GetCarByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

