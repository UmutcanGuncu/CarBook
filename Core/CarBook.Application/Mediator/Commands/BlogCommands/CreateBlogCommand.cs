using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.BlogCommands
{
	public class CreateBlogCommand : IRequest
	{
        public string Title { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı Url
        public DateTime CreatedDate { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
    }
}

