using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartupFuncExample56;

[assembly: WebJobsStartup(typeof(Startup))]

namespace StartupFuncExample56
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddAuthenticationCore();
            builder.Services.AddAuthorization();
            builder.Services.AddMvcCore();
            builder.Services.AddLogging();

            builder.Services.AddSingleton<IMyService, MyService>();
        }
    }
}
