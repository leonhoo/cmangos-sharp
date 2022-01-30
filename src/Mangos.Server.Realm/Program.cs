﻿using System.Linq;
using Mangos.Core;
using Mangos.Server.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Mangos.Server.Realm;

public static class Program
{
    public static void Main(string[] args)
    {
        var container = new ServiceCollection().AddInfrastructure().AddApp().BuildServiceProvider();
        container.GetService<App>()?.Run(args);
    }

    /// <summary>
    /// Put all new app services in here.
    /// </summary>
    private static IServiceCollection AddApp(this IServiceCollection serviceCollection) =>
        serviceCollection
            .MapServices(
                MangosServerRealmTypes.Get(),
                MangosCoreTypes.Get(),
                MangosServerCoreTypes.Get()
            )
            .AddLogging()
            .AddConf("realmd.conf")
            .AddDatabase("RealmdConf");
}