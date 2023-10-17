using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skrejp_api.Data;
using skrejp_api.ViewModels;

namespace skrejp_api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SlikeController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;
        public ApplicationDbContext _dbContext;

        public SlikeController(ILogger<WeatherForecastController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this._dbContext = dbContext;
        }

        [HttpGet]
        public  async Task<ActionResult> GetAll(int nekretninaID)
        {
            var data = await _dbContext.Slike.Where(s=>s.nekretninaID==nekretninaID)
                .Select(s => new SlikeGetVM
                {
                    //id=s.ID,
                    url=s.url,
                    nekretninaID=s.nekretninaID
                })
                .ToListAsync();
            return Ok(data);
        }
    }
}