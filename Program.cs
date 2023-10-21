using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HotChocolate;
using Microsoft.AspNetCore.Builder;

namespace HCSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = WebApplication.CreateBuilder(args);

            hostBuilder
                .Services
                .AddDbContext<AppDbContext>(options =>
                    options.UseInMemoryDatabase("SampleDb"));

            hostBuilder
                .Services
                .AddGraphQLServer()
                .AddFiltering()
                .AddSorting()
                .AddProjections()
                .AddQueryType<Query>();

            var app = hostBuilder.Build();

            app.MapGraphQL("/graphql");

            app.Run();
        }
    }
}
