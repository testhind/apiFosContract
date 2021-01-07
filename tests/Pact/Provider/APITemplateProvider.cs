using Cds.Foundation.Test.Pact.Provider;
using Cds.APITemplate.Api.Bootstrap;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;

namespace Cds.APITemplate.Tests.Pact.Provider
{
    /// <summary>
    /// Defines the APITemplate provider
    /// </summary>
    public class APITemplateProvider : BaseProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APITemplateProvider"/> class
        /// </summary>
        public APITemplateProvider() : base()
        {
            Host = Program.CreateHostBuilder(new string[0])
                    .ConfigureWebHostDefaults(builder =>
                        builder.UseEnvironment("Development")
                            .UseUrls(WebHostUri)
                            .ConfigureTestServices(services =>
                            {

            #pragma warning disable S125
                                //Add your mocks here
                                /*Exemple to mock HttpClient :
                                 * services
                                   .AddHttpClient([MyHttpClient])
                                   .AddHttpMessageHandler(() => new GlobalServiceHandler());
                                */
            #pragma warning restore S125
                            }))
                            .Build();

            Host.Start();
        }
    }
}