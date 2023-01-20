using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CountryController : ControllerBase
    {
        private CanImmDBContext _dbContext;

        private readonly ILogger<CountryController> _logger;

        public CountryController(ILogger<CountryController> logger, CanImmDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "AllCountry")]
        [ActionName("GetAllCountry")]
        public ActionResult<List<Country>> GetAllCountry()
        {
            var query = _dbContext.Country.ToList();
            return query;
        }
        [HttpPost(Name = "AddCountry")]
        [ActionName("AddCountry")]
        public ActionResult AddCountry(Country country)
        {
            var query = _dbContext.Country.Add(country);
            _dbContext.SaveChanges();
            return Ok();

        }
    }
}