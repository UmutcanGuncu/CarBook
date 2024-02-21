using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Mediator.Results.AuthorResults
{
	public class GetAuthorQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}

