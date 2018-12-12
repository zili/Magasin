using Magasin.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Magasin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        // GET: api/Article
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return Article.getList();
        }


    }
}
