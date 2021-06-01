using MediatR;
using MediatrDemo.Mediatr.Commands;
using MediatrDemo.Mediatr.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetCarQueryByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllCarQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
