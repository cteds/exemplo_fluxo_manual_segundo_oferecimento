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
    }
}
