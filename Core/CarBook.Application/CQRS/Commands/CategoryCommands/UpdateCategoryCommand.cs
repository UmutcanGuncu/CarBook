using System;
namespace CarBook.Application.CQRS.Commands.CategoryCommands
{
	public class UpdateCategoryCommand
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

}

