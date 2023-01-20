using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private CanImmDBContext _dbContext;

        private readonly ILogger<CountryController> _logger;

        public UserController(ILogger<CountryController> logger, CanImmDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost(Name = "AddUser")]
        [ActionName("AddUser")]
        public ActionResult AddUser(User user)
        {
            var query = _dbContext.User.Add(user);
            _dbContext.SaveChanges();
            return Ok();

        }
        
    }
}