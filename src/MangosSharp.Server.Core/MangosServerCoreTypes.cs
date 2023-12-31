﻿using System;
using System.Collections.Generic;
using MangosSharp.Server.Core.Services;
using MangosSharp.Server.Core.Sockets;

namespace MangosSharp.Server.Core;

public static class MangosServerCoreTypes
{
    public static IEnumerable<(Type Service, Type Implementation)> Get()
    {
        yield return (typeof(IAccountService), typeof(AccountService));
        yield return (typeof(ISocketDaemon), typeof(SocketDaemon));
        yield return (typeof(IAppCancellation), typeof(AppCancellation));
        yield return (typeof(IBuildInfoService), typeof(BuildInfoService));
    }
}