using Microsoft.Extensions.DependencyInjection;
using System;

namespace StartupFuncExample56
{
    public class MyService : IMyService
    {
        private readonly IServiceCollection serviceCollection;

        public MyService(IServiceCollection _serviceCollection)
        {
            serviceCollection = _serviceCollection;
        }

        public void DoSomething()
        {
            serviceCollection.AddAuthenticationCore();

            Console.WriteLine("Doing something!");
        }
    }
}