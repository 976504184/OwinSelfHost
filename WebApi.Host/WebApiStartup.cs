using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Host
{
    public class WebApiStartup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
          
            RegisterApi(config);

            app.UseWebApi(config);

            config.EnsureInitialized();
        }

        /// <summary>
        /// 注册Api
        /// </summary>
        /// <param name="config"></param>
        protected  void RegisterApi(HttpConfiguration config)
        {
            WebApiConfig.Register(config);
        }
    }
}
