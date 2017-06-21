using System.Net;

namespace WebApi
{
    public class ApiResult
    {
        public ApiResult()
        {
            code = (int)HttpStatusCode.OK;
        }

        /// <summary>
        /// 成功或者失败标志
        /// </summary>
        public bool flag { get; set; }

        /// <summary>
        /// 返回结果编码
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public object oData { get; set; }
    }
}
