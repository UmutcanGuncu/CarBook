using System;
namespace CarBook.Application.CQRS.Commands.BrandCommands
{
	public class UpdateBrandCommand
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}

