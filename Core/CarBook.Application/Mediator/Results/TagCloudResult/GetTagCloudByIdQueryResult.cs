using System;
namespace CarBook.Application.Mediator.Results.TagCloudResult
{
	public class GetTagCloudByIdQueryResult
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid BlogId { get; set; }
    }
}

