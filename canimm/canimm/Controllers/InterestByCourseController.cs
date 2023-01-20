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
    public class InterestByCourseController : ControllerBase
    {
        private CanImmDBContext _dbContext;

        private readonly ILogger<InterestByCourseController> _logger;

        public InterestByCourseController(ILogger<InterestByCourseController> logger, CanImmDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "InterestByCourse")]
        [ActionName("GetUsersInterstByCourse")]
        public ActionResult<List<InterestByCourse>> GetUsersInterstByCourse(Course course)
        {
            var query = _dbContext.InterestByCourse.ToList().Where(x => x.Course.Id == course.Id)
                .ToList();
            return query;
        }

    }
}