﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Rubberduck.RPC.Proxy.SharedServices.Abstract;
using Rubberduck.RPC.Proxy.SharedServices.Server.Configuration;

namespace Rubberduck.RPC.Platform
{
    /// <summary>
    /// A common base class for Rubberduck3 server applications.
    /// </summary>
    public abstract class RubberduckServerApp<TJsonRpcServer, TServerProxy, TOptions> : BackgroundService
        where TJsonRpcServer : IJsonRpcServer
        where TOptions : SharedServerCapabilities, new()
    {
        protected RubberduckServerApp(TJsonRpcServer server, IEnumerable<IJsonRpcTarget> proxies, IServerStateService<TOptions> stateService)
        {
            Server = server;
            RpcServerProxy = proxies.OfType<TServerProxy>().SingleOrDefault();

            ServerState = stateService;
        }

        protected TJsonRpcServer Server { get; }
        protected TServerProxy RpcServerProxy { get; }

        protected IServerStateService<TOptions> ServerState { get; }

        protected abstract void RegisterServerProxyEvents(TServerProxy proxy);


        protected sealed override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Greetings();
            RegisterServerProxyEvents(RpcServerProxy);
            return Server.StartAsync(stoppingToken);
        }

        private void Greetings()
        {
            var state = ServerState.Info;

            Console.WriteLine(new string('*', 80));
            Console.WriteLine(@"
                (#########
              ##..........##(
             ##.......##/...#######
             ##...........##(///##
  (###        ##..........,####                                     @@@@@@@
  #*...####    ,##.........#          @@@@@@@@@@@  .@@@@@@@@@@.    @@/**,,@@*.
 ##..........,*,............##*        @@@,    @@/.  @@*.    @@/        *@@@/,
 ##...........................##       @@@@@@@@@/*   @@*.    @@@,      &@@@@,
 ##............................##      @@@*,,@@@(    @@*.    @@(,         ,@@*
  #*...........................##    (@@@@@@   @@@@@@@@@@@@@@@/*  @@@@@@@@@@/*
   ##.........................##      .,****,    ,*,,,*****,,.      ,******,
    *##.....................##.
       (###(..........,####
");
            Console.WriteLine(new string('*', 80));
            Console.WriteLine($"{state.Name} v{state.Version} (C)2014-{DateTime.Today.Year} Rubberduck project contributors");
            Console.WriteLine($"Process ID: {state.ProcessId}");
        }
    }
}
