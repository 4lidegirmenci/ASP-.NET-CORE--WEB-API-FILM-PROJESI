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
    [Route("api/Film")]
    public class FilmController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public FilmController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]

        public IActionResult GetAllFilms([FromQuery] FilmParameters filmParameters)
        {


            var pagedResult = _manager.FilmServices.GetAllFilms(filmParameters, false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.films);



        }

        [HttpGet("{id:int}")]

        public IActionResult GetOneFilm([FromRoute(Name = "id")] int id)
        {




            var film = _manager.FilmServices.GetFilmById(id, false);



            return Ok(film);




        }


        [HttpPost]

        public IActionResult CreateOneFilm([FromBody] FilmDtoForInsertion filmDto)
        {


            if (filmDto is null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }
            var film = _manager.FilmServices.CreateOneFilm(filmDto);


            return StatusCode(201, film);





        }





    }
}
