using System;
namespace CarBook.Application.CQRS.Queries.BannerQueries
{
	public class GetBannerByIdQuery
	{
		public Guid Id { get; set; }

        public GetBannerByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

