using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.CQRS.Commands.AboutCommands;
using CarBook.Application.CQRS.Handlers.AboutHandlers;
using CarBook.Application.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Mvc;


namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly CreateAboutCommandHandler _createAboutCommandHandler;
        private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;
        private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetAboutQueryHandler _getAboutQueryHandler;

        public AboutController(CreateAboutCommandHandler createAboutCommandHandler, UpdateAboutCommandHandler updateAboutCommandHandler, RemoveAboutCommandHandler removeAboutCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutQueryHandler getAboutQueryHandler)
        {
            _createAboutCommandHandler = createAboutCommandHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
            _removeAboutCommandHandler = removeAboutCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutByIdList(Guid id)
        {
            var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _createAboutCommandHandler.Handle(command);
            return Ok("Hakkında Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(Guid id)
        {
            await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("Hakkında Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await _updateAboutCommandHandler.Handle(command);
            return Ok("Hakkında Bilgisi Güncellendi");
        }
    }
}

