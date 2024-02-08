using System;
namespace CarBook.Application.CQRS.Commands.CategoryCommands
{
	public class RemoveCategoryCommand
	{
		public Guid Id { get; set; }

        public RemoveCategoryCommand(Guid id)
        {
            Id = id;
        }
    }
}

