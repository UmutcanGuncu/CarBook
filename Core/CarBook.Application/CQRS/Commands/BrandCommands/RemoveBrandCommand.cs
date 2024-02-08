using System;
namespace CarBook.Application.CQRS.Commands.BrandCommands
{
	public class RemoveBrandCommand
	{
		public Guid Id { get; set; }

        public RemoveBrandCommand(Guid id)
        {
            Id = id;
        }
    }
}

