using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.CommentCommands;
using CarBook.Application.Mediator.Queries.CommentQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCommentList()
        {
            var values = await _mediator.Send(new GetCommentQuery());
            return Ok(values);
        }
        [HttpGet("getCommentByBlogIdList/{blogId}")]
        public async Task<IActionResult> GetCommentByBlogIdList(Guid blogId)
        {
            var values = await _mediator.Send(new GetCommentByBlogIdQuery(blogId));
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetCommentByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteComment(Guid id)
        {
            await _mediator.Send(new RemoveCommentCommand(id));
            return Ok("Comment Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment Başarıyla Güncellendi");
        }
    }
}

