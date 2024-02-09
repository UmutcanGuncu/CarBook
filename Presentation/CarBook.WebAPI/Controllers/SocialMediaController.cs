using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocialMediaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetSocialMediaList()
        {
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMediaByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddSocialMedia(CreateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Social Media Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Social Media Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSocialMedia(Guid id)
        {
            await _mediator.Send(new RemoveSocialMediaCommand(id));
            return Ok("Social Media Başarıyla Güncellendi");
        }
    }
}

