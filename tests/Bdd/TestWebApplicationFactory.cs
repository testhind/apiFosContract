﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Cds.APITemplate.Api.Bootstrap;

namespace Cds.APITemplate.Tests.Bdd
{
    public class TestWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Production");

            builder.ConfigureTestServices(
                    services => {
#pragma warning disable S125
                        // Add your GLOBAL mocks here
                        /* Exemple to mock HttpClient :
                         services
                           .AddHttpClient([MyHttpClient])
                           .AddHttpMessageHandler(() => new GlobalServiceHandler());
                        */
#pragma warning restore S125
                    });

            base.ConfigureWebHost(builder);
        }
    }
}
