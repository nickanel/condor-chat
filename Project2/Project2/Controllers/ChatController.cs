using Project2.Models;
using System.Linq;
using System.Web.Mvc;

namespace Project2.Controllers
{
    [Authorize(Roles = "User, Admin")]
    //[Authorize]
    public class ChatController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Chat
        public ActionResult Index()
        {
            ChatViewModel vm = new ChatViewModel()
            {
                Users = db.Users.ToList()
            };
            return View(vm);
        }
    }
}