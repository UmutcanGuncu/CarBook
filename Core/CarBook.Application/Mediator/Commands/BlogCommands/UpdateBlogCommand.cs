using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.BlogCommands
{
	public class UpdateBlogCommand : IRequest
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı 
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }

    }
}

