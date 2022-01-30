using System;
using System.Linq;
using System.Net;
using System.Threading;
using Mangos.Core.Infrastructure;
using Mangos.Data.Context;
using Mangos.Server.Core.Services;
using Mangos.Server.Core.Sockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mangos.Server.World;

public class App
{
    private readonly IConfiguration _configuration;
    private readonly IDatabase _database;
    private readonly ISocketDaemon _socketDaemon;
    private readonly ISocketHandler _socketHandler;
    private readonly IConsoleProvider _consoleProvider;

    public App(IConfiguration configuration, IDatabase database, ISocketDaemon socketDaemon,
        ISocketHandler socketHandler, IConsoleProvider consoleProvider)
    {
        _configuration = configuration;
        _database = database;
        _socketDaemon = socketDaemon;
        _socketHandler = socketHandler;
        _consoleProvider = consoleProvider;
    }

    public void Run(string[] args)
    {
        var worldEndpoint = new IPEndPoint(
            IPAddress.Parse(_configuration["MangosdConf.BindIP"]),
            int.Parse(_configuration["MangosdConf.WorldServerPort"]));

        var cancel = new CancellationTokenSource();
        _socketDaemon.ListenAsync(worldEndpoint, _socketHandler, cancel.Token);
        while (!cancel.IsCancellationRequested)
        {
            _consoleProvider.In.ReadLine();
            cancel.Cancel();
        }
    }
}