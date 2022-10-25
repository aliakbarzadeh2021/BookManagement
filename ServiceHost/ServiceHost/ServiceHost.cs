using System;
using Microsoft.Owin.Hosting;

namespace ServiceHost.ServiceHost
{
    public class ServiceHost
    {
        private IDisposable _webApp;

        public string BaseAddress => "http://localhost:9000/";

        public void Start()
        {
            _webApp = WebApp.Start<Startup>(BaseAddress);
        }

        public void Stop()
        {
            _webApp.Dispose();
        }
    }
}
