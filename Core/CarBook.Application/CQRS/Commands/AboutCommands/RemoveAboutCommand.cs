using System;
namespace CarBook.Application.CQRS.Commands.AboutCommands
{
	public class RemoveAboutCommand
	{
		public Guid Id{ get; set; }

        public RemoveAboutCommand(Guid id)
        {
            Id = id;
        }
    }
}
