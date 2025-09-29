using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class usersController : Controller
    {
        public ViewResult GetAll()
        {
            List<string> users = new List<string>()
            {
                "mohammad", "ahmad", "anas", "aya", "tareq"
            };
            return View("Index", users);
        }
    }
}
