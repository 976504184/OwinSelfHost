using System.Web.Http;

namespace WebApi.Controller
{
    public class HomeController:BaseApiController
    {
        [HttpGet]
        public ApiResult GetTest()
        {
            return new ApiResult();
        }
    }
}
