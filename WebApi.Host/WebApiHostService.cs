using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Host
{
    public partial class WebApiHostService : ServiceBase
    {
        public WebApiHostService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Start OWIN host 
            var url = new UriBuilder("http", "+", 9000).ToString();

            WebApp.Start<WebApiStartup>(url);
        }

        protected override void OnStop()
        {
        }
    }
}
