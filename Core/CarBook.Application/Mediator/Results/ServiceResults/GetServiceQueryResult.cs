using System;
namespace CarBook.Application.Mediator.Results.ServiceResults
{
	public class GetServiceQueryResult
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}

