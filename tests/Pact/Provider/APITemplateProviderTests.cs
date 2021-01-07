using Cds.Foundation.Test.Pact.Provider;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Cds.APITemplate.Tests.Pact.Provider
{
    /// <summary>
    /// Defines the APITemplate provider tests
    /// </summary>
    public class APITemplateProviderTests : BaseProviderTests<APITemplateProvider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APITemplateProviderTests"/> class
        /// </summary>
        /// <param name="output">The Xunit output</param>
        /// <param name="provider">The provider</param>
        public APITemplateProviderTests(ITestOutputHelper output, APITemplateProvider provider) : base(output, provider)
        {
        }

#pragma warning disable S125
        //[Fact]
        //public Task Provider_APITemplate() => EnsureProviderHonoursPactAsync();
#pragma warning restore S125
    }
}
