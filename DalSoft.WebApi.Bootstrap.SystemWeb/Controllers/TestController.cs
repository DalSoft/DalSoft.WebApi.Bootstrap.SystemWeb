using System.Net.Http;
using System.Web.Http;

namespace DalSoft.WebApi.SystemWeb.Bootstrap.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet, Route("test/hello")]
        public HttpResponseMessage Hello()
        {
            return new HttpResponseMessage
            {
                Content = new StringContent("world"),
            };
        }
    }
}