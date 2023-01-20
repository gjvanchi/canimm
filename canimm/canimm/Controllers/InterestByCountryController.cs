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
    public class InterestByCountryController : ControllerBase
    {
        private CanImmDBContext _dbContext;

        private readonly ILogger<InterestByCountryController> _logger;

        public InterestByCountryController(ILogger<InterestByCountryController> logger, CanImmDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "InterestByCountry")]
        [ActionName("GetUsersInterstByCountry")]
        public ActionResult<List<InterestByCountry>> GetUsersInterstByCountry(string countryCode)
        {
            var query = _dbContext.InterestByCountry.ToList().Where(x => x.CountryCode.CountryCode == countryCode)
                .ToList();
            return query;
        }

    }
}