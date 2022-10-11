using Games.Domains;
using Games.Interfaces;
using Games.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Games.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudiosController : ControllerBase
    {
        private IStudio StudioRepository { get; set; }

        public StudiosController()
        {
            StudioRepository = new StudioRepository();
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(StudioRepository.List());
        }

        [HttpPost]
        public IActionResult Create(Studio newStudio)
        {
            StudioRepository.Create(newStudio);

            return StatusCode(201);
        }
    }
}
