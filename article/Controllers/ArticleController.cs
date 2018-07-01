using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models.Article.ArticleController;

//https://webapphuddle.com/design-tags-feature-in-web-apps/
//https://www.maketecheasier.com/5-online-tools-to-create-tag-clouds/
//https://www.ebates.com/rf.do?referrerid=vdPURIW4fINgWguIRm6jRQ%3D%3D&eeid=28585
//https://market.mashape.com/
namespace Article.Controllers
{
    [Route("[controller]/[action]")]
    public class ArticleController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        public ArticleController(IConfiguration configuration, ILogger<ArticleController> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult PostArticle([FromBody] PostArticleModel data)
        {
            return Ok(new { Name = "Chinna", Email = "chinnarao@live.com" });
        }
    }
}