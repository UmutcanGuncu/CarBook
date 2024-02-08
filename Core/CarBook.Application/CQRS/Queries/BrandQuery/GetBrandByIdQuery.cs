using System;
namespace CarBook.Application.CQRS.Queries.BrandQuery
{
	public class GetBrandByIdQuery
	{
		public Guid Id { get; set; }

        public GetBrandByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

