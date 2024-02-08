using System;
namespace CarBook.Application.CQRS.Commands.BannerCommands
{
	public class RemoveBannerCommand
	{
		public Guid  Id { get; set; }

        public RemoveBannerCommand(Guid id)
        {
            Id = id;
        }
    }
}

