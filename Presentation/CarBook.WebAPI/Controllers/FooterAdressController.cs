using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.FooterAdressCommands;
using CarBook.Application.Mediator.Queries.FooterAdressQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FooterAdressController : Controller
    {
        private readonly IMediator _mediator;

        public FooterAdressController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetFooterAdressList()
        {
            var values = await _mediator.Send(new GetFooterAdressQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAdressByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetFooterAdressByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddFooterAdress(CreateFooterAdressCommand command)
        {
            await _mediator.Send(command);
            return Ok("FooterAdress Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFootedAdress(UpdateFooterAdressCommand command)
        {
            await _mediator.Send(command);
            return Ok("FooterAdress Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFooterAdress(Guid id)
        {
            await _mediator.Send(new RemoveFooterAdressCommand(id));
            return Ok("FooterAdress Başarıyla Silindi");
        }
    }
}

