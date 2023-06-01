using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(StartupFuncExample56.Startup))]

namespace StartupFuncExample56
{
    public  class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddAuthenticationCore();
            builder.Services.AddAuthorization();
            builder.Services.AddMvcCore();
            builder.Services.AddLogging();

            builder.Services.AddSingleton<IMyService, MyService>();
        }
    }
}
