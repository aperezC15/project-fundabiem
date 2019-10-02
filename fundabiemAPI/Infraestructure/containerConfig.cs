using System;
using Autofac;
using BrokerServices.common;
using Microsoft.AspNetCore.Http;
using Serilog;
using EntityModelFundabien;
using EntityModelFundabien.common;
using EntityModelFundabien.Interfaces;
using AutoMapper;

namespace fundabiemAPI.Infraestructure
{
    public sealed class containerConfig<TC, TI> : Module
         where TI : struct, IEquatable<TI>
         where TC : struct
    {
        private readonly appSettings appSettings;
        private readonly connectionStrings connectionStrings;
        private readonly ILogger logger;
        public readonly IMapper mapper;
        private readonly dbContext context;

        public containerConfig(connectionStrings connectionStrings, appSettings appSettings, ILogger logger, IMapper mapper, dbContext context)
        {
            this.connectionStrings = connectionStrings;
            this.appSettings = appSettings;
            this.logger = logger;
            this.mapper = mapper;
            this.context = context;
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
                .InstancePerDependency();
            logger.Information("Success connection");
            #endregion

            #region "Custom Business Classes -bls-"
            builder.Register(c => new clsFundabiemCommonLogic<TI, TC>(mapper, context
            )).InstancePerDependency()
            .As<IFundabiemCommonLogic<TI, TC>>();
            #endregion

        }
    }
}

