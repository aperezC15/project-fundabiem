using System;
using Autofac;
using Serilog;

namespace fundabiemAPI.Infraestructure
{
    public sealed class containerConfig<TC, TI> : Module
         where TI : struct, IEquatable<TI>
         where TC : struct
    {
        private readonly appSettings appSettings;
        private readonly connectionStrings connectionStrings;
        private readonly ILogger logger;

        public containerConfig(connectionStrings connectionStrings, appSettings appSettings, ILogger logger)
        {
            this.connectionStrings = connectionStrings;
            this.appSettings = appSettings;
            this.logger = logger;
        }
    }
}
