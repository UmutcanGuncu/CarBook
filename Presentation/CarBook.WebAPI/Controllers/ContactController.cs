using System;
using CarBook.Application.CQRS.Commands.ContactCommand;
using CarBook.Application.CQRS.Handlers.ContactHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ContactController : ControllerBase
	{
		private readonly GetContactQueryHandler _getContactQueryHandler;
		private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
		private readonly CreateContactCommandHandler _createContactCommandHandler;
		private readonly UpdateContactCommandHandler _updateContactCommandHandler;
		private readonly RemoveContactCommandHandler _removeContactCommandHandler;

        public ContactController(GetContactQueryHandler getContactQueryHandler, GetContactByIdQueryHandler getContactByIdQueryHandler, CreateContactCommandHandler createContactCommandHandler, UpdateContactCommandHandler updateContactCommandHandler, RemoveContactCommandHandler removeContactCommandHandler)
        {
            _getContactQueryHandler = getContactQueryHandler;
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _createContactCommandHandler = createContactCommandHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
            _removeContactCommandHandler = removeContactCommandHandler;
        }

        [HttpGet]
		public async Task<IActionResult> GetContactList()
		{
			var values = await _getContactQueryHandler.Handle();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetContactByIdList(Guid id)
		{
			var value = await _getContactByIdQueryHandler.Handle(new Application.CQRS.Queries.ContactQueries.GetContactByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> AddContact(CreateContactCommand command)
		{
			await _createContactCommandHandler.Handle(command);
			return Ok("Contact Başarıyla Eklendi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
		{
			await _updateContactCommandHandler.Handle(command);
			return Ok("Contact Başarıyla Güncellendi");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteContact(Guid id)
		{
			await _removeContactCommandHandler.Handle(new RemoveContactCommand(id));
			return Ok("Contact Başarıyla Silindi");
		}
	}
}

