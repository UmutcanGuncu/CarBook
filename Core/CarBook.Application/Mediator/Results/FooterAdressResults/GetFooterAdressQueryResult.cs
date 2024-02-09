using System;
namespace CarBook.Application.Mediator.Results.FooterAdressResults
{
	public class GetFooterAdressQueryResult
	{
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

