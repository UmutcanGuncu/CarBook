using System;
namespace CarBook.Application.CQRS.Queries.CategoryQueries
{
	public class GetCategoryByIdQuery
	{
		public Guid Id { get; set; }

        public GetCategoryByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

