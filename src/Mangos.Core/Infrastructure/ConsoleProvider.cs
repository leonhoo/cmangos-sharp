﻿using System;
using System.IO;

namespace Mangos.Core.Infrastructure;

public class ConsoleProvider : IConsoleProvider
{
    public TextReader In => Console.In;
    public TextWriter Out => Console.Out;
}