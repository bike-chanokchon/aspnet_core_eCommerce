using eTicket.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    [Route("[controller]")]
    public class ActorController : Controller
    {
        private readonly AppDbContext context;

        public ActorController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var data = this.context.Actors.ToList();
            return View(data);
        }
    }
}