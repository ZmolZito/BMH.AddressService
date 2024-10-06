using BMH.AddressService.Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMH.AddressService.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Tilføj IHttpClientFactory
            services.AddHttpClient<IAddressService, AddressService>(client =>
            {
                client.BaseAddress = new Uri("https://api.dataforsyningen.dk/");
            });


            return services;
        }
    }
}
