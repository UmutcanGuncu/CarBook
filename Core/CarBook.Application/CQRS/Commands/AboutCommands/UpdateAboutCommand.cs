using System;
namespace CarBook.Application.CQRS.Commands.AboutCommands
{
	public class UpdateAboutCommand
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}

