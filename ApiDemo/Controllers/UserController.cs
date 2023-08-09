using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
       public IActionResult Get()
        {
            List<User> users = new List<User>();
            User u = new User()
            {
                Id = 1,
                Name = "Test",
                Password = "password",
                Email = "a@a.com",
                UserName = "Test"
            };
            users.Add(u);

            return Ok(users);
        }
    }





}
