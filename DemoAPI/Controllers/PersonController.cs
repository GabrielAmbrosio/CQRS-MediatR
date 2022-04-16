using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        private readonly IMediator _mediator;

        public PersonController(ILogger<PersonController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<List<PersonModel>> GetPeople() => await _mediator.Send(new GetPersonListQuery());

        [HttpGet("{id}")]
        public async Task<PersonModel> GetPeopleById(int id) => await _mediator.Send(new GetPersonByIdQuery(id));
      
        [HttpPost]
        public async Task<int> CreatePerson([FromBody] PersonModel person)
        {
            return await _mediator.Send(new InsertPersonCommand(person.FirstName,person.LastName));
        }


    }
}
