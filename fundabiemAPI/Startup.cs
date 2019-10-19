using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using fundabiemAPI.Infraestructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Autofac;
using Serilog;
using AutoMapper;
using EntityModelFundabien.mapper;
using BrokerServices.common;

namespace fundabiemAPI
{
    public class Startup
    {
        private IConfiguration configuration { get; }
        private IOptions<appSettings> appSettings;
        private IOptions<connectionStrings> connectionStrings;
        public IMapper mapper { get; set; }
        private dbContext context;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.mapper = mappingConfig.CreateMapper();
            this.context = new dbContext();
        }

        MapperConfiguration mappingConfig = new MapperConfiguration(mc => {
            mc.AddProfile(new MappingProfile());
        });

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new containerConfig<int,int>(connectionStrings.Value, appSettings.Value, Log.Logger, mapper, context));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(mapper);

            //this for replacement environment variables
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddOptions();
            services.Configure<connectionStrings>(configuration.GetSection("connectionStrings"));
            services.Configure<appSettings>(configuration.GetSection("security"));
            var builderProvider = services.BuildServiceProvider();
            connectionStrings = builderProvider.GetService<IOptions<connectionStrings>>();
            appSettings = builderProvider.GetService<IOptions<appSettings>>();
            //for validate jwt with login server
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = appSettings.Value.Authority;
                    options.RequireHttpsMetadata = false;
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("FundaBienPolicy", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    //this you can configure access policys, e.g edad => 18
                });
            });
            

            services.AddCors(options=> {
                options.AddPolicy("default", policy =>
                {
                    policy.WithOrigins(appSettings.Value.allowedHosts)
                    .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetPreflightMaxAge(new System.TimeSpan(5, 0, 0, 0));
                });
            });
            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(swagger =>
            {
                var contact = new Contact() { Name = SwaggerConfiguration.ContactName, Url = SwaggerConfiguration.ContactUrl };
                swagger.SwaggerDoc(SwaggerConfiguration.DocNameV1,
                                   new Info
                                   {
                                       Title = SwaggerConfiguration.DocInfoTitle,
                                       Version = SwaggerConfiguration.DocInfoVersion,
                                       Description = SwaggerConfiguration.DocInfoDescription,
                                       Contact = contact
                                   }
                                    );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(SwaggerConfiguration.EndpointUrl, SwaggerConfiguration.EndpointDescription);
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("default");
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
