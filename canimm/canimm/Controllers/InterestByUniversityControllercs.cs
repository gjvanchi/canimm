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
    public class InterestByUniversityController : ControllerBase
    {
        private CanImmDBContext _dbContext;

        private readonly ILogger<InterestByUniversityController> _logger;

        public InterestByUniversityController(ILogger<InterestByUniversityController> logger, CanImmDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "InterestByUniversity")]
        [ActionName("GetUsersInterstByUniversity")]
        public ActionResult<List<InterestByUniversity>> GetUsersInterstByUniversity(University university)
        {
            var query = _dbContext.InterstByUniversity.ToList().Where(x => x.University.Id == university.Id)
                .ToList();
            return query;
        }

    }
}