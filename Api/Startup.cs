using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLPlayground.Api.Helpers;
using GraphQLPlayground.Api.Models;
using GraphQLPlayground.Core.Data;
using GraphQLPlayground.Data;
using GraphQLPlayground.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLPlayground
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddHttpContextAccessor();
            services.AddSingleton<ContextServiceLocator>();
            services.AddDbContext<PokemonContext>(options => options.UseSqlite("Data Source=pokemon.db"));
            services.AddTransient<IPokemonRepository, PokemonRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<PokemonQuery>();
            services.AddSingleton<PokemonType>();
            services.AddSingleton<TypeType>();
            services.AddSingleton<ISchema>(sp => new PokemonSchema(new FuncDependencyResolver(type => sp.GetService(type))));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, PokemonContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseMvc();
            context.Database.Migrate();
        }
    }
}
