using AuthService.Models;
using AuthService.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService service; 
        public UserController(UserService service)
        {
            this.service = service; 
        }
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return service.GetUsers(); 
        }
        [HttpGet("{id: length(24)}")]
        public ActionResult<User> GetUser(string id)
        {
            var user = service.GetUser(id); 
            return Json(user); 
        }

        [HttpPost]
        public ActionResult<User> Create (User user)
        {
            service.Create(user); 
            return Json(user); 
        }
    }
}