using System;
namespace CarBook.Application.CQRS.Results.ContactResults
{
	public class GetContactQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}

