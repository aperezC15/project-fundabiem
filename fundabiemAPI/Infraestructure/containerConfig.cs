using System;
using Autofac;
using BrokerServices.common;
using Microsoft.AspNetCore.Http;
using Serilog;
using EntityModelFundabien;
using EntityModelFundabien.common;
using EntityModelFundabien.Interfaces;

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

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            #region "Infrastructure"
            logger.Information("I'm going to connection data  base");
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();
            builder
                .RegisterType<dbContext>()
                .WithParameter("Options", connectionSQL.con(connectionStrings.postgreSql))
                .InstancePerLifetimeScope();
            logger.Information("Success connection");
            #endregion

            #region "Custom Business Classes -bls-"
            builder.Register(c => new clsFundabiemCommonLogic<TI, TC>(
            )).InstancePerDependency()
            .As<IFundabiemCommonLogic<TI, TC>>();
            #endregion

        }
    }
}

