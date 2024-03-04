using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.AuthorCommands;
using CarBook.Application.Mediator.Queries.AuthorQueris;
using CarBook.Application.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        public IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAuthorList()
        {
            var values = await _mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }
        [HttpGet("byBlog/{authorId}/{blogId}")]
        public async Task<IActionResult> GetAuthorByBlogId(Guid authorId, Guid blogId)
        {
            var value = await _mediator.Send(new GetBlogByAuthorIdQuery(authorId, blogId));
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthor(CreateAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Author Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Author Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            await _mediator.Send(new RemoveAuthorCommand(id));
            return Ok("Author Başarıyla Silindi");
        }
    }
}

