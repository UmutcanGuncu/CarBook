using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Mediator.Commands.PricingCommands;
using CarBook.Application.Mediator.Queries.PricingQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PricingController : Controller
    {
        private readonly IMediator _mediator;

        public PricingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetPricingList()
        {
            var values = await _mediator.Send(new GetPricingQuery());
            return Ok(values);
        }
        [HttpGet("pricingWithCar")]
        public async Task<IActionResult> GetPricingWithCarList()
        {
            var values = await _mediator.Send(new GetPricingWithCarQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricingByIdList(Guid id)
        {
            var value = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddPricing(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePricing(Guid id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("Pricing Başarıyla Silindi");
        }
    }
}

