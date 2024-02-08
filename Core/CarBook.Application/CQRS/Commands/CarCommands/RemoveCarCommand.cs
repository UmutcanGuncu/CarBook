using System;
namespace CarBook.Application.CQRS.Commands.CarCommands
{
	public class RemoveCarCommand
	{
		public Guid Id { get; set; }

        public RemoveCarCommand(Guid id)
        {
            Id = id;
        }
    }
}

