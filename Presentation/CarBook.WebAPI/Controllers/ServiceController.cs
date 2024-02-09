using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.ServiceCommands;
using CarBook.Application.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : Controller
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetServiceList()
        {
            var values = await _mediator.Send(new GetServiceQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddService(CreateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Service Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Service Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteService(Guid id)
        {
            await _mediator.Send(new RemoveServiceCommand(id));
            return Ok("Service Başarıyla Silindi");
        }
    }
}

