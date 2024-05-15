using CleanArchitecture.Application;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;
        public MoviesController(IMovieService service)
        {
            this._service = service;
        }
 
        [HttpGet]
        public ActionResult Get()
        {
            var movies = _service.GetAllMovies();
            return Ok(movies);
        }

    }
}
