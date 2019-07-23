using GraphQLPlayground.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLPlayground.Api.Helpers
{
    public class ContextServiceLocator
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor) => this.httpContextAccessor = httpContextAccessor;

        public IPokemonRepository PokemonRepository => httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IPokemonRepository>();
    }
}