using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.LocationCommands;
using CarBook.Application.Mediator.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task <IActionResult> GetLocationList()
        {
            var values = await _mediator.Send(new GetLocationQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetLocationByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetLocationByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task <IActionResult> AddLocation(CreateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Location Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task <IActionResult> UpdateLocation(UpdateLocationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Location Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task <IActionResult> DeleteLocation(Guid id)
        {
            await _mediator.Send(new RemoveLocationCommand(id));
            return Ok("Location Başarıyla Silindi");
        }
    }
}

