using System;
using System.Diagnostics.CodeAnalysis;

using Cds.Foundation.Data;
using Cds.APITemplate.Domain.ItemAggregate;
using Cds.APITemplate.Domain.ItemAggregate.Abstractions;
using Cds.APITemplate.Infrastructure.Data.Items;
using Cds.APITemplate.Infrastructure.ItemRepository.Abstractions;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Cds.APITemplate.Api.Bootstrap
{
#pragma warning disable S1200

    /// <summary>
    /// Represents the application's bootstrap.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Startup
    {
#region Fields

        private readonly IConfiguration _configuration;
        private readonly IHostEnvironment _environment;

#endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        /// <param name="configuration">The configuration.</param>
        public Startup(IHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {

            services
                .AddHealthChecks()
                .AddCheck("Default", () => HealthCheckResult.Healthy("OK"))
               // .AddSqlServer("DefaultConnection", _configuration.GetConnectionString("DefaultConnection"))
                // [You can add more checks here...]
            ;

            services
                // Registers the Swagger generator, defining one Swagger document.
                .AddCustomSwaggerGen<Startup>()
                // Registers data services to inject read & write connections.
                .AddData((builder) =>
                {
                    builder
                        .WithConfigurationRoot((IConfigurationRoot)_configuration)
                        .AddSqlServer()
                        ;
                })
                // Registers a single HTTP client in `IHttpClientFactory` with Cdiscount default policies (Polly).
                .AddDefaultHttpClient()
                // Registers services to compress outputs.
                .AddResponseCompression()
                // Registers sensitive encryption services (e.g. to encrypt cookies).
                .AddDataProtection();

            services
                // Registers MVC & Web API services.
                .AddMvcCore()
                    .AddDataAnnotations()
                    .AddAuthorization()
                    // Registers services to generate OpenApi Specifications (via third party library).
                    .AddApiExplorer()
                    // Registers Cdiscount's services to handle field selection, paging, etc.
                    .AddUnifiedRestApi();
            // Registers domain handler.
            services.AddScoped<ItemHandler>();

            if (_environment.IsDevelopment())
            {
                var inMemoryRepository = new InMemoryRepository();

                services
                    .AddScoped<IItemRepository>(f => inMemoryRepository)
                    .AddScoped<IItemReadRepository>(f => inMemoryRepository);
            }
            else
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                Func<IDbConnection> connectionFactory = () => new SqlConnection(connectionString);
                var repository = new SqlRepository(connectionFactory);
                services
                    .AddSingleton<IItemRepository>(repository)
                    .AddSingleton<IItemReadRepository>(repository);
            }
            // [You can add your own application services here...]
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="application">The application.</param>
        public void Configure(IApplicationBuilder application)
        {
            if (_environment.IsDevelopment())
            {
                // Uses development tools.
                application
                    .UseBrowserLink()
                    .UseDeveloperExceptionPage()
                    .UseWebApiExceptionHandler();
            }
            else
            {
                application.UseExceptionMonithorLogging();
            }

            application.UseRouting();

            application
                .UseResponseCompression()
                .UseCustomSwagger<Startup>()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapHealthChecks();
                });
        }
    }
#pragma warning restore S1200
}
