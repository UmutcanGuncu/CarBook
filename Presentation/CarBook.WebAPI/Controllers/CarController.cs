using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.CQRS.Commands.CarCommands;
using CarBook.Application.CQRS.Handlers.CarHandlers;
using CarBook.Application.Mediator.Queries.CarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly IMediator _mediator;

        public CarController(GetCarByIdQueryHandler getCarByIdQueryHandler, CreateCarCommandHandler createCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, IMediator mediator)
        {
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarList()
        {
            var values = await _getCarWithBrandQueryHandler.Handle(); //Brand ile birleştirilmiş şekilde listeler
            return Ok(values);
        }
        [HttpGet("/[controller]/listFiveBrand")]
        public async Task<IActionResult> GetFiveCarList()
        {
            var values = await _mediator.Send(new GetFiveCarQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarByIdList(Guid id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new Application.CQRS.Queries.CarQueries.GetCarByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddCar(CreateCarCommand command)
        {
            var carId = await _createCarCommandHandler.Handle(command);
            return Ok(carId);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Car Başarıyla Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(Guid id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Car Başarıyla Silindi");
        }
    }
}

