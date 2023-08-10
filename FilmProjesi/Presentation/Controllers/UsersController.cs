using Entities.DataTransferObject;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/User")]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public UsersController(IServiceManager manager)
        {
            _manager = manager;
        }




        [HttpGet]

        public IActionResult GetAllUsers([FromQuery] UserParameters userParameters)
        {


            var pagedResult = _manager.UserServices.GetAllUsers(userParameters, false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.users);




        }

        [HttpPost]

        public IActionResult CreateOneUser([FromBody] UserDtoForInsertion userDto)
        {

            if (userDto is null)
            {
                return BadRequest();//400
            }
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }
            var user = _manager.UserServices.CreateOneUser(userDto);

            return StatusCode(201, user);


        }


        [HttpGet("{id:int}")]

        public IActionResult GetOneUser([FromRoute(Name = "id")] int id)
        {


            var user = _manager.UserServices.GetUserById(id, false);



            return Ok(user);



        }

        [HttpPut("{id:int}")]

        public IActionResult UpdateOneUser([FromRoute(Name = "id")] int id, [FromBody] UserDtoForUpdate userdto)
        {


            if (userdto is null)
            {
                return BadRequest();//400
            }
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }
            _manager.UserServices.UpdateOneUser(id, userdto, false);




            return NoContent();//204



        }
    }
}
