// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using IdentityServer.dbContext;
using IdentityServer.dbContext.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace IdentityServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IConfiguration configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //add db context for postgresql on azure
            
            services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            options.UseNpgsql(Environment.GetEnvironmentVariable("STRING_CONNECTION")));

            // uncomment, if you wan to add an MVC-based UI
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
            services.AddIdentity<ApplicationUser, IdentityRole>(options => {
                options.Lockout.MaxFailedAccessAttempts = 8;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
               .AddDefaultTokenProviders();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsFundabiemRules",
                cors =>
                {
                    cors.WithOrigins("http://localhost:8080")
                                        .AllowAnyHeader()
                                        .AllowAnyOrigin()
                                        .AllowAnyMethod();
                });
            });

            var builder = services.AddIdentityServer()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApis())
                //.AddTestUsers(Config.GetUsers())
                .AddAspNetIdentity<ApplicationUser>()
                .AddInMemoryClients(Config.GetClients());
            
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") =="Development")
            {
                builder.AddDeveloperSigningCredential();
            }
            else
            {
                throw new Exception("need to configure key material");
            }

           

            // ref: https://github.com/aspnet/Docs/issues/2384
            //app.UseForwardedHeaders(forwardOptions);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            var forwardOptions = new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto,
                RequireHeaderSymmetry = false
            };

            forwardOptions.KnownNetworks.Clear();
            forwardOptions.KnownProxies.Clear();

            // uncomment if you want to support static files
            app.UseForwardedHeaders(forwardOptions);
            app.UseCors("CorsFundabiemRules");
            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseIdentityServer();

            // uncomment, if you wan to add an MVC-based UI
            app.UseMvcWithDefaultRoute();
        }
    }
}