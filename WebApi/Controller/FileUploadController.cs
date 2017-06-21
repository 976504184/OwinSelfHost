using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebApi.Controller
{
    public class FileUploadController : BaseApiController
    {
        [HttpPost]
        public object FileUpload()
        {
            var apiResult = new ApiResult();

            var header = Request.Headers;

            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = @"F:/";
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                StringBuilder sb = new StringBuilder();

                var task = Request.Content.ReadAsMultipartAsync(provider);

                task.Wait();

                foreach (var file in provider.FileData)
                {
                    FileInfo fileInfo = new FileInfo(file.LocalFileName);
                    sb.Append(string.Format("Uploaded file: {0} ({1} bytes)\n", fileInfo.Name, fileInfo.Length));
                }
                apiResult.msg = sb.ToString();
            }
            catch (System.Exception e)
            {

                apiResult.msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e).ToString();
            }
            return apiResult;

        }
    }
}
