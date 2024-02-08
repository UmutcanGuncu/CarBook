using System;
namespace CarBook.Application.CQRS.Results.CategoryResults
{
	public class GetCategoryByIdQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

