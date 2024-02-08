using System;
namespace CarBook.Application.CQRS.Commands.ContactCommand
{
	public class RemoveContactCommand
	{
		public Guid Id { get; set; }

        public RemoveContactCommand(Guid id)
        {
            Id = id;
        }
    }
}

