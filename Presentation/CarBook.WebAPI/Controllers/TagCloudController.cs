using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Mediator.Queries.SocialMediaQueries;
using CarBook.Application.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagCloudController : Controller
    {
        private readonly IMediator _mediator;

        public TagCloudController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetTagCloudList()
        {
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloudByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddTagCloud(CreateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("TagCloud Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("TagCloud Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTagCloud(Guid id)
        {
            await _mediator.Send(new RemoveTagCloudCommand(id));
            return Ok("TagCloud Başarıyla Güncellendi");
        }
    }
}

