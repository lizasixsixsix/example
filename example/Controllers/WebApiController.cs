using System.Web.Http;
using example.Filters;

namespace example.Controllers
{
    public class WebApiController : ApiController
    {
        [GoogleAnalytics]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
