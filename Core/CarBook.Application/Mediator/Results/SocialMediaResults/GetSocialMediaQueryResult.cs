using System;
namespace CarBook.Application.Mediator.Results.SocialMediaResults
{
	public class GetSocialMediaQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
    }
}

