using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

using WebApp.Models;
using System.Linq;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CanImmController : ControllerBase
    {
        private CanImmDBContext _dbContext;

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CanImmController> _logger;

        public CanImmController(ILogger<CanImmController> logger, CanImmDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "AllUniversity")]
        [ActionName("GetAllUniversity")]
        public ActionResult<List<University>> GetAllUniversity()
        {
            var query = _dbContext.University.Include(x => x.Country).ToList();
            return query;
        }
        [HttpGet(Name = "GetUniversityByCountry")]
        [ActionName("GetUniversityByCountry")]
        public ActionResult<List<University>> GetUniversityByCountry(int ccode)
        {
            var query = _dbContext.University.Include(x => x.Country)
                .Where(y => y.Country.Id == ccode)
                .ToList();

            return query;

        }
        [HttpPost(Name = "AddUniversity")]
        [ActionName("AddUniversity")]
        public ActionResult AddUniversity(University university)
        {
            var query = _dbContext.University.Add(university);
            _dbContext.SaveChanges();
            return Ok();

        }
    }
}