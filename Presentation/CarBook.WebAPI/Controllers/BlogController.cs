using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.BlogCommands;
using CarBook.Application.Mediator.Commands.FooterAdressCommands;
using CarBook.Application.Mediator.Queries.BlogQueries;
using CarBook.Application.Mediator.Queries.FooterAdressQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetBlogList() //author ve category include edilmemiş
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogByIdList(Guid id) //author ve category include edilmemiş
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("/api/[controller]/last3BlogList")]
        public async Task<IActionResult> GetLast3BlogList()
        {
            var values = await _mediator.Send(new GetLast3BlogListWithAuthorAndCategoryQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(Guid id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog Başarıyla Silindi");
        }
    }
}

