using System;
namespace CarBook.Application.CQRS.Queries.ContactQueries
{
	public class GetContactByIdQuery
	{
		public Guid Id { get; set; }

        public GetContactByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

